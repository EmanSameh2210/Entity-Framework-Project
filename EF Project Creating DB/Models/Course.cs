using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Creating_DB.Models
{
    public class Course
    {
        public int ID { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentID { get; set; }

        [ForeignKey("Instructor")]
        public int? InstructorID { get; set; }
        public int? Duration { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Instructor? Instructor { get; set; }
        public ICollection<CourseStudent> Course_Students { get; set; } = new HashSet<CourseStudent>();
        public ICollection<CourseSession> Course_Sessions { get; set; } = new HashSet<CourseSession>();
    }
}
