using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_Project_Creating_DB.Models
{
    public class Instructor
    {
        
        public int Id { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [StringLength(20)]
        public string? FirstName { get; set; }

        [StringLength(20)]
        public string? LastName { get; set; }
        public string? Phone { get; set; }

        public virtual Department? Department { get; set; }
        
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        public virtual ICollection<CourseSession> Course_Session { get; set; } = new HashSet<CourseSession>();
       
    }
}
