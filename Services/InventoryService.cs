using SmartStock.Data;

public class InventoryService : IInventoryService
{
    private readonly SmartStockDbContext _context;

    public InventoryService(SmartStockDbContext context)
    {
        _context = context;
    }

    public async Task ReceiveStockAsync(
        Guid productId,
        Guid warehouseId,
        decimal quantity)
    {
        // logic here
    }

    public async Task IssueStockAsync(
        Guid productId,
        Guid warehouseId,
        decimal quantity)
    {
        // logic here
    }
}