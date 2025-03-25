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

namespace EF_Project_Forms
{
    public partial class DeleteCourseSessionForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public DeleteCourseSessionForm()
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int CSId = Convert.ToInt32(CSCombo.SelectedValue);


                var relatedCourseAt = db.CourseSessionAttendances.Where(c => c.Id == CSId);
                db.CourseSessionAttendances.RemoveRange(relatedCourseAt);
                db.SaveChanges();


                var CS = db.CourseSessions.FirstOrDefault(c => c.Id == CSId);
                if (CS != null)
                {
                    db.CourseSessions.Remove(CS);
                    db.SaveChanges();
                    MessageBox.Show("Course Session deleted successfully!");
                    LoadCourseSessions();
                }
                else
                {
                    MessageBox.Show("Course Session not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting course Session: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }
        

        private void CSCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CSCombo.SelectedValue is int selected_id)
            {
                var CS = db.CourseSessions.FirstOrDefault(c => c.Id == selected_id);
                if (CS != null)
                {
                    date.Text = CS.Date.ToString();
                    title.Text = CS.Title;
                    InsId.Text = CS.InstructorID.ToString();
                    cId.Text = CS.CourseID.ToString();
                }
            }
        }

        private void DeleteCourseSessionForm_Load(object sender, EventArgs e)
        {
            LoadCourseSessions();
        }
        private void LoadCourseSessions()
        {
            try
            {
                var CS = db.CourseSessions.Select(c => new { ID = c.Id }).ToList();

                CSCombo.DataSource = CS;
                CSCombo.DisplayMember = "ID";
                CSCombo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course Sessions: " + ex.Message);
            }
        }
    }
}
