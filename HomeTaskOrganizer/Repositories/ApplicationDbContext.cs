using HomeTaskOrganizer.Models;
using Microsoft.EntityFrameworkCore;
namespace HomeTaskOrganizer.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
