using Microsoft.EntityFrameworkCore;

namespace WebAppCustom.Models
{
    public class ApplicationContext : DbContext
    {
        string connection = "server=localhost;user=root;password=Battlefield3;database=customersdb";
        public DbSet<Client> Clients { get; set; }
        public DbSet<InfoClient> InfoClients { get; set; }
        public DbSet<ListShop> ListShops { get; set; }
        //public ApplicationContext(DbContextOptions<ApplicationContext> options)
        //    : base(options)
        //{
        //    Database.EnsureCreated();
        //}
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }
    }
}
