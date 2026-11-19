using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartStock.Data;
using SmartStock.Entities;

namespace SmartStock.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WarehousesController : ControllerBase
{
    private readonly SmartStockDbContext _context;

    public WarehousesController(SmartStockDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Warehouse>>> GetWarehouses()
    {
        return await _context.Warehouses.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Warehouse>> CreateWarehouse(
        Warehouse warehouse)
    {
        warehouse.Id = Guid.NewGuid();

        _context.Warehouses.Add(warehouse);

        await _context.SaveChangesAsync();

        return Ok(warehouse);
    }
}