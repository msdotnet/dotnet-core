using Microsoft.AspNetCore.Mvc;
using Qualminds.Cms.Core.Contracts.Repositories;
using Qualminds.Cms.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualminds.Cms.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeachersController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        // GET: api/Teachers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetAsync()
        {
            return (await _teacherRepository.Get()).ToList();
        }

        // GET: api/Teachers/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Teacher>> Get(long id)
        {
            var teacher =  await _teacherRepository.GetById(id);
            if (teacher == null)
                return NotFound();
            return teacher;
        }

        // POST: api/Teachers
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Teacher teacher)
        {
            var teacherCreated = await _teacherRepository.Add(teacher);
            return CreatedAtAction(nameof(Get), new { id = teacherCreated.Id }, teacherCreated);
        }

        // PUT: api/Teachers/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(long id, [FromBody] Teacher teacher)
        {
            if (id != teacher.Id)
                return BadRequest();
            await _teacherRepository.Update(teacher);
            return NoContent();
        }

        // DELETE: api/teachers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var teacher = await _teacherRepository.GetById(id);
            if (teacher == null)
                return NotFound();
            await _teacherRepository.Remove(teacher);
            return NoContent();
        }
    }
}
