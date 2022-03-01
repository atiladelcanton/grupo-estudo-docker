using client.Models;
using Microsoft.EntityFrameworkCore;

namespace client.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

         public DbSet<Client> client {get;set;}
    }
}