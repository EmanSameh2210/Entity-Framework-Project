using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace EF_Project_Creating_DB.Models
{
    public class Department
    {
        public int ID { get; set; }
        public int? ManagerID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]

        public string? Location { get; set; }

        public virtual Instructor? Instructor { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

       

       
}
}
