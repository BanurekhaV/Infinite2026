using Microsoft.EntityFrameworkCore;
namespace EFCore_CodeFirst.Models
{
    public class EFCoreCodeContext : DbContext
    {
        public EFCoreCodeContext(DbContextOptions<EFCoreCodeContext> options):base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Department> Departments { get; set; }
    }
}
