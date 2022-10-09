using GenericRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; } = null!;
    }
}
