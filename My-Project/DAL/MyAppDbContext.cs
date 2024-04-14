using Microsoft.EntityFrameworkCore;
using My_Project.Models;

namespace My_Project.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
