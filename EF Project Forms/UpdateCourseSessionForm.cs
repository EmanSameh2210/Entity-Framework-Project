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
    public partial class UpdateCourseSessionForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public UpdateCourseSessionForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CourseSessionForm frm = new CourseSessionForm();
            frm.Show();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (CSCombo.SelectedValue is int selected_id)
                {
                    var CS = db.CourseSessions.FirstOrDefault(c => c.Id == selected_id);

                    if (CS != null)
                    {
                        CS.Date = DateTime.Parse( date.Text);
                        CS.Title = title.Text;
                        CS.InstructorID = int.Parse(InsId.Text);
                        CS.CourseID = int.Parse(cId.Text);

                        db.SaveChanges();

                        MessageBox.Show("Course Session updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Course Session not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateCourseSessionForm_Load(object sender, EventArgs e)
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
    }
}
