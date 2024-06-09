using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Receipt.WebApi.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Receipt.WebApi.Data.configuration
{
    public class OrderItemsConfiguration : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> builder)
        {
            builder.HasKey(x => new {x.OrderId, x.ItemId});

            builder.Property(x => x.Quantity)
                .HasColumnType("int")
                .IsRequired();

            builder.ToTable("OrderItems");
        }
    }
}
