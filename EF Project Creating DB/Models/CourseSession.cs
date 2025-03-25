using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Creating_DB.Models
{
    
    public class CourseSession
    {
        public int Id { get; set; }

        [ForeignKey("Course")]
        public int? CourseID { get; set; }

        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public DateTime Date { get; set; }
        public string? Title { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Instructor? Instructor { get; set; }
        public virtual ICollection<CourseSessionAttendance> Course_Session_Attendance { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
