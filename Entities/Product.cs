namespace SmartStock.Entities;

public class Product
{
    public Guid Id { get; set; }

    public string SKU { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string UnitOfMeasure { get; set; } = "PCS";

    public bool IsActive { get; set; } = true;
}