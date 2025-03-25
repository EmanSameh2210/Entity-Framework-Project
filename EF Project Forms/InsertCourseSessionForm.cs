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

namespace EF_Project_Forms
{
    public partial class InsertCourseSessionForm : Form
    {
        EF_ProjectContext context = new EF_ProjectContext();
        public InsertCourseSessionForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CourseSessionForm courseSessionForm = new CourseSessionForm();
            courseSessionForm.Show();
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                var courseSession = new CourseSession
                {

                    Date = DateTime.Parse(date.Text),
                    Title = title.Text,
                    CourseID = int.Parse(cId.Text),
                    InstructorID = int.Parse(InsId.Text),
                };


                context.CourseSessions.Add(courseSession);


                context.SaveChanges();

                MessageBox.Show("CourseSession added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void InsertCourseSessionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
