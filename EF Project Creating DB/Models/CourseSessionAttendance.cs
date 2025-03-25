using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Creating_DB.Models
{
    public class CourseSessionAttendance
    {
        public int Id { get; set; }

        [ForeignKey("CourseSession")]
        public int? CourseSessionId { get; set; }

        [ForeignKey("Student")]
        public int? StudentID { get; set; }
        public int? Grade { get; set; }
        public string? Notes { get; set; }

        public virtual CourseSession? CourseSession { get; set; }
        public virtual Student? Student { get; set; }
    }
}
