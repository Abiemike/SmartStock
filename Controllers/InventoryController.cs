using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartStock.Data;
using SmartStock.Entities;
using SmartStock.Enums;
using SmartStock.Requests;

namespace SmartStock.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{
    private readonly SmartStockDbContext _context;

    public InventoryController(
        SmartStockDbContext context)
    {
        _context = context;
    }

    [HttpPost("receive")]
    public async Task<IActionResult> ReceiveStock(
        ReceiveStockRequest request)
    {
        var balance =
            await _context.InventoryBalances
                .FirstOrDefaultAsync(x =>
                    x.ProductId == request.ProductId &&
                    x.WarehouseId == request.WarehouseId);

        if (balance == null)
        {
            balance = new InventoryBalance
            {
                Id = Guid.NewGuid(),
                ProductId = request.ProductId,
                WarehouseId = request.WarehouseId,
                QuantityOnHand = 0,
                QuantityReserved = 0,
                LastUpdatedAt = DateTime.UtcNow
            };

            _context.InventoryBalances.Add(balance);
        }

        balance.QuantityOnHand += request.Quantity;
        balance.LastUpdatedAt = DateTime.UtcNow;

        _context.InventoryTransactions.Add(
            new InventoryTransaction
            {
                Id = Guid.NewGuid(),
                ProductId = request.ProductId,
                WarehouseId = request.WarehouseId,
                Quantity = request.Quantity,
                TransactionDate = DateTime.UtcNow,
                Type = InventoryTransactionType.Receipt
            });

        await _context.SaveChangesAsync();

        return Ok(balance);
    }
}