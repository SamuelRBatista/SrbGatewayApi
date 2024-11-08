using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProductApi.Model;

namespace ProductApi.Data
{
    public class DBContextClass : DbContext
    {
        private readonly IConfiguration Configuration;

        public DBContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Product> Products { get; set; }
        

    }
}
