using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Creating_DB.Models
{
    public class CourseStudent
    {
        public int? CourseID { get; set; }
        public int? StudentID { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Student? Student { get; set; }
    }
}
