namespace SmartStock.Requests;

public class ReceiveStockRequest
{
    public Guid ProductId { get; set; }

    public Guid WarehouseId { get; set; }

    public decimal Quantity { get; set; }
}