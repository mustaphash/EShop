using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {
        }
        public ShopContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-6149JFK;Initial Catalog=EShop;Integrated Security=True;Pooling=False");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
