using Microsoft.EntityFrameworkCore;
using NetCoreAI.Project1_ApiDemo.Entities;

namespace NetCoreAI.Project1_ApiDemo.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BERKAY\\SQLEXPRESS;Initial Catalog=ApiAIDb;Integrated Security=True;Trust Server Certificate=True");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
