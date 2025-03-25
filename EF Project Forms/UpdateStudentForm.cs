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
    public partial class UpdateStudentForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();
            frm.Show();
            this.Close();
        }

        
       
        private void LoadStudents()
        {
            try
            {
                var student = db.Students.Select(s => new { ID = s.ID}).ToList();

                StudentCombo.DataSource = student;
                StudentCombo.DisplayMember = "ID";
                StudentCombo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }


        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void StudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentCombo.SelectedValue is int selected_id)
            {
                var student = db.Students.FirstOrDefault(s => s.ID == selected_id);
                if (student != null)
                {
                    first_name.Text = student.FirstName;
                    last_name.Text = student.LastName;
                    ph.Text = student.Phone;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentCombo.SelectedValue is int selected_id)
                {
                    var student = db.Students.FirstOrDefault(s => s.ID == selected_id);

                    if (student != null)
                    {
                       
                        student.FirstName = first_name.Text;
                        student.LastName = last_name.Text;
                        student.Phone = ph.Text;

                        db.SaveChanges();

                        MessageBox.Show("Student updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Student not found!");
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
