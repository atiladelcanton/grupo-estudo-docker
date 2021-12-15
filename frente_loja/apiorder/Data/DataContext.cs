using Microsoft.EntityFrameworkCore;
using apiorder.Models;

namespace apiorder.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Customer> customer {get;set;}
        public DbSet<Order> order {get;set;}
        public DbSet<Item> item {get;set;}
    }
}