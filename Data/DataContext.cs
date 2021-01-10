//NOSSO BANCO DE DADOS EM MEMÓRIA
using balt_api_web.Models;
using Microsoft.EntityFrameworkCore;

namespace balt_api_web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {}
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}