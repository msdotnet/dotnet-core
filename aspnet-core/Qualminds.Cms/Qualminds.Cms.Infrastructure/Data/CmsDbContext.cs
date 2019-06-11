using Microsoft.EntityFrameworkCore;
using Qualminds.Cms.Core.Models;

namespace Qualminds.Cms.Infrastructure.Data
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> options): base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
