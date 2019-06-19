using Microsoft.EntityFrameworkCore;
using Qualminds.Cms.Core.Contracts.Repositories;
using Qualminds.Cms.Core.Entities;
using Qualminds.Cms.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualminds.Cms.Infrastructure.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly CmsDbContext _dbContext;

        public TeacherRepository(CmsDbContext dbContext)
        {
            _dbContext = dbContext;
            if(_dbContext.Teachers.Count() <= 0)
            {
                _dbContext.Teachers.Add(new Teacher { Name = "Indrani", DepartmentId = 1 });
                _dbContext.SaveChanges();
            }
        }
        public async Task<IEnumerable<Teacher>> Get()
        {
            return await _dbContext.Teachers.ToListAsync();
        }
        public async Task<Teacher> GetById(long id)
        {
            return await _dbContext.Teachers.FindAsync(id);
        }
        public async Task<Teacher> Add(Teacher teacher)
        {
            _dbContext.Teachers.Add(teacher);
            await _dbContext.SaveChangesAsync();
            return teacher;
        }
        public async Task Update(Teacher teacher)
        {
            _dbContext.Entry(teacher).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task Remove(long id)
        {
            var teacher = await GetById(id);
            await Remove(teacher);
        }
        public async Task Remove(Teacher teacher)
        {
            _dbContext.Teachers.Remove(teacher);
            await _dbContext.SaveChangesAsync();
        }
    }
}
