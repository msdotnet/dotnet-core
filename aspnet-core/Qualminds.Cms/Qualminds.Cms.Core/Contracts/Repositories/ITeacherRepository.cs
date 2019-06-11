using System.Collections.Generic;
using System.Threading.Tasks;
using Qualminds.Cms.Core.Models;

namespace Qualminds.Cms.Core.Contracts.Repositories
{
    public interface ITeacherRepository
    {
        Task<Teacher> Add(Teacher teacher);
        Task<IEnumerable<Teacher>> Get();
        Task<Teacher> GetById(long id);
        Task Remove(long id);
        Task Remove(Teacher teacher);
        Task Update(Teacher teacher);
    }
}