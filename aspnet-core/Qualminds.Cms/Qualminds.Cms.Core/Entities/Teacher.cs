using System.ComponentModel.DataAnnotations;

namespace Qualminds.Cms.Core.Entities
{
    public class Teacher
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
