using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Data{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}