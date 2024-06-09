using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Receipt.WebApi.Entities;

namespace Receipt.WebApi.Data.configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("int")
                .IsRequired();
        
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasMany(e => e.Items)
                .WithMany(e => e.Orders)
                .UsingEntity<OrderItems>();

            builder.ToTable("Orders");
        }
    }
}
