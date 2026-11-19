using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InventoryBalanceConfiguration :
    IEntityTypeConfiguration<InventoryBalance>
{
    public void Configure(
        EntityTypeBuilder<InventoryBalance> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => new
        {
            x.ProductId,
            x.WarehouseId
        }).IsUnique();

        builder.Property(x => x.QuantityOnHand)
               .HasPrecision(18, 2);

        builder.Property(x => x.QuantityReserved)
               .HasPrecision(18, 2);

        builder.Property(x => x.RowVersion)
               .IsRowVersion();
    }
}