using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Creating_DB.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string? FirstName { get; set; }
        [StringLength(20)]
        public string? LastName { get; set; }
        public string? Phone { get; set; }

        //relations
        public virtual ICollection<CourseStudent> Course_student{ get; set; } = new HashSet<CourseStudent>();
        public virtual ICollection<CourseSessionAttendance> Course_Session_Attendance { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
