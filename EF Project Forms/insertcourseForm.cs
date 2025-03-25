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
using EF_Project_Forms.Models;

namespace EF_Project_Forms.Course_CRUD
{
    public partial class insertcourseForm : Form
    {
        EF_ProjectContext context = new EF_ProjectContext();
        public insertcourseForm()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                var course = new Course
                {
                    
                    Name = course_name.Text,
                    Duration = int.Parse(course_duration.Text),
                    DepartmentID = int.Parse(txtDeptId.Text),
                    InstructorID = int.Parse(txtInsId.Text),
                };


                context.Courses.Add(course);

                MessageBox.Show("قبل الحفظ");
                context.SaveChanges();
                MessageBox.Show("بعد الحفظ");
                MessageBox.Show("CourseSession added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void insertcourseForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Close();
        }
    }
}
