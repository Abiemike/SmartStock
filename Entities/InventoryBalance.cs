using System.ComponentModel.DataAnnotations;

public class InventoryBalance
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid WarehouseId { get; set; }

    public decimal QuantityOnHand { get; set; }

    public decimal QuantityReserved { get; set; }

    public decimal AvailableQuantity =>
        QuantityOnHand - QuantityReserved;

    public DateTime LastUpdatedAt { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; } = Array.Empty<byte>();
}