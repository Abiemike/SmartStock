using SmartStock.Enums;
public class InventoryTransaction
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid WarehouseId { get; set; }

    public InventoryTransactionType Type { get; set; }

    public decimal Quantity { get; set; }

    public DateTime TransactionDate { get; set; }
}