using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EF_Project_Forms.Context;

namespace EF_Project_Forms.Course_CRUD
{
    public partial class UpdatecourseForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public UpdatecourseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (CourseCombo.SelectedValue != null && int.TryParse(CourseCombo.SelectedValue.ToString(), out int selected_id))
                {
                    var course = db.Courses.FirstOrDefault(c => c.ID == selected_id);

                    if (course != null)
                    {
                        course.Name = course_name.Text;
                        course.Duration = int.Parse(course_duration.Text);
                        course.DepartmentID = int.Parse(txtDeptId.Text);
                        course.InstructorID = int.Parse(txtinstructorId.Text);

                        db.SaveChanges();

                        MessageBox.Show("Course updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Course not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdatecourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            try
            {
                var courses = db.Courses.Select(c => new { ID = c.ID, Name = c.Name }).ToList();

                CourseCombo.DataSource = courses;
                CourseCombo.DisplayMember = "ID";
                CourseCombo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_Click(object sender, EventArgs e)
        {

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
