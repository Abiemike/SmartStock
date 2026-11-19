using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InventoryTransactionConfiguration :
    IEntityTypeConfiguration<InventoryTransaction>
{
    public void Configure(
        EntityTypeBuilder<InventoryTransaction> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Quantity)
               .HasPrecision(18, 2);
    }
}