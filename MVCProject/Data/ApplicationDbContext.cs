using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MVCProject.Models;

namespace MVCProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student {get; set;}
    }
}