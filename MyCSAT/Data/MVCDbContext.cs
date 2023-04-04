using Microsoft.EntityFrameworkCore;
using MyCSAT.Models.Domain;

namespace MyCSAT.Data
{
    public class MVCDbContext : DbContext
    {
        //constructor with options
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }

        //properties
        public DbSet<Employee> Employees { get; set; }
    }
}
