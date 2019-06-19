using System.ComponentModel.DataAnnotations;

namespace Qualminds.Cms.Core.Models
{
    public class Teacher
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
