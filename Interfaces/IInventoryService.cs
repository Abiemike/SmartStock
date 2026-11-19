public interface IInventoryService
{
    Task ReceiveStockAsync(
        Guid productId,
        Guid warehouseId,
        decimal quantity);

    Task IssueStockAsync(
        Guid productId,
        Guid warehouseId,
        decimal quantity);
}