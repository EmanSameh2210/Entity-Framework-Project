using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Project_Forms.Context;

namespace EF_Project_Forms.Course_CRUD
{
    public partial class DeletecourseForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();

        public DeletecourseForm()
        {
            InitializeComponent();
        }

        private void DeletecourseForm_Load(object sender, EventArgs e)
        {
            LoadCourseIDs();
        }

        private void LoadCourseIDs()
        {
            try
            {
                var courses = db.Courses
                                .Select(c => new { ID = c.ID }) 
                                .ToList();

                CourseCombo.DataSource = courses;
                CourseCombo.ValueMember = "ID";   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = Convert.ToInt32(CourseCombo.SelectedValue);

                
                var relatedSessions = db.CourseSessions.Where(cs => cs.CourseID == courseId);
                db.CourseSessions.RemoveRange(relatedSessions);
                db.SaveChanges(); 

                
                var course = db.Courses.FirstOrDefault(c => c.ID == courseId);
                if (course != null)
                {
                    db.Courses.Remove(course);
                    db.SaveChanges();
                    MessageBox.Show("Course deleted successfully!");
                    LoadCourseIDs();
                }
                else
                {
                    MessageBox.Show("Course not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting course: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CourseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseCombo.SelectedValue != null && int.TryParse(CourseCombo.SelectedValue.ToString(), out int selected_id))
            {
                var course = db.Courses.FirstOrDefault(c => c.ID == selected_id);
                if (course != null)
                {
                    course_name.Text = course.Name;
                    course_duration.Text = course.Duration.ToString();
                    txtDeptId.Text = course.DepartmentID.ToString();
                    txtinstructorId.Text = course.InstructorID.ToString();
                }
            }
        }
    }
}