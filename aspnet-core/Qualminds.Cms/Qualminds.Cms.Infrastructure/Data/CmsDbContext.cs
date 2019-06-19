using Microsoft.EntityFrameworkCore;
using Qualminds.Cms.Core.Entities;

namespace Qualminds.Cms.Infrastructure.Data
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> options): base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.HasData(new Department { Id = 1, Name = "CSE" });
            });
        }
    }
}
