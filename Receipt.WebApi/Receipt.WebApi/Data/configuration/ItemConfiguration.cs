using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Receipt.WebApi.Entities;

namespace Receipt.WebApi.Data.configuration
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("VarChar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasPrecision(15, 2);

            builder.Property(x => x.InStock)
                .HasColumnType("int")
                .IsRequired();

            builder.ToTable("Items");

            builder.HasData(LoadItems());
        }

        private static List<Item> LoadItems()
        {
            return new List<Item>{
                new Item { Id = 1, Name = "Phone", Price = 699m, InStock = 50 },
                new Item { Id = 2, Name = "Laptop", Price = 999m, InStock = 30 },
                new Item { Id = 3, Name = "Tablet", Price = 399m, InStock = 40 },
                new Item { Id = 4, Name = "Camera", Price = 299m, InStock = 20 },
                new Item { Id = 5, Name = "Headset", Price = 59m, InStock = 70 },
                new Item { Id = 6, Name = "Mouse", Price = 29m, InStock = 100 },
                new Item { Id = 7, Name = "Keyboard", Price = 49m, InStock = 80 },
                new Item { Id = 8, Name = "Monitor", Price = 199m, InStock = 25 },
                new Item { Id = 9, Name = "Printer", Price = 89m, InStock = 15 },

            };
        }
    }
}
