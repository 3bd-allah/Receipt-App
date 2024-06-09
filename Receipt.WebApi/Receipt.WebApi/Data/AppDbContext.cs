using Microsoft.EntityFrameworkCore;
using Receipt.WebApi.Entities;

namespace Receipt.WebApi.Data
{
    public class AppDbContext:DbContext
    {
        //static readonly string connectionString = "Server=localhost; User ID=root; Password=abdo5044; Database=ReceiptDB";

        public virtual DbSet<Item> Items { get; set; }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }


    }
}
