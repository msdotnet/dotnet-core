using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Qualminds.Cms.Core.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
