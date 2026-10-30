using Microsoft.EntityFrameworkCore;
using WebApplicationTesting.Models;
namespace WebApplicationTesting.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students => Set<Student>();
    }
}