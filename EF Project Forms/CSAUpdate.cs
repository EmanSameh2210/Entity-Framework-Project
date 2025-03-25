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
    public partial class CSAUpdate : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public CSAUpdate()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CourseSessionAttendanceForm courseSessionAttendanceForm = new CourseSessionAttendanceForm();
            courseSessionAttendanceForm.Show();
            this.Close();
        }

        private void CSAUpdate_Load(object sender, EventArgs e)
        {
            LoadCSA();
        }

        private void LoadCSA()
        {
            try
            {
                var CSA = db.CourseSessionAttendances.Select(c => new { ID = c.Id }).ToList();

                CSACombo.DataSource = CSA;
                CSACombo.DisplayMember = "ID";
                CSACombo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses Session Attendance: " + ex.Message);
            }
        }
        private void CSACombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CSACombo.SelectedValue is int selected_id)
            {
                var CSA = db.CourseSessionAttendances.FirstOrDefault(c => c.Id == selected_id);
                if (CSA != null)
                {
                    grade.Text = CSA.Grade.ToString();
                    note.Text = CSA.Notes;
                    sid.Text = CSA.StudentID.ToString();
                    csId.Text = CSA.CourseSessionId.ToString();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (CSACombo.SelectedValue is int selected_id)
                {
                    var CSA = db.CourseSessionAttendances.FirstOrDefault(c => c.Id == selected_id);

                    if (CSA != null)
                    {
                        CSA.Grade = int.Parse(grade.Text);
                        CSA.Notes= note.Text;
                        CSA.StudentID = int.Parse(sid.Text);
                       CSA.CourseSessionId = int.Parse(csId.Text);

                        db.SaveChanges();

                        MessageBox.Show("Course Session Attendance updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Course Session Attendance not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
