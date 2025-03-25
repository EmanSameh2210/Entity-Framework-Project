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
    public partial class UpdateInsForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public UpdateInsForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            InstructorForm instructorForm = new InstructorForm();
            instructorForm.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsCombo.SelectedValue is int selected_id)
                {
                    var Instructor = db.Instructors.FirstOrDefault(I => I.Id == selected_id);

                    if (Instructor != null)
                    {
                        Instructor.FirstName = first_name.Text;
                        Instructor.LastName = last_name.Text;
                        Instructor.Phone = phone.Text;
                        Instructor.DepartmentId = int.Parse(deptid.Text);

                        db.SaveChanges();

                        MessageBox.Show("Instructor data updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Instructor not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateInsForm_Load(object sender, EventArgs e)
        {
            LoadInstructors();
        }

        private void LoadInstructors()
        {
            try
            {
                var Instructors = db.Instructors.Select(I => new { ID = I.Id }).ToList();

                InsCombo.DataSource = Instructors;
                InsCombo.DisplayMember = "ID";
                InsCombo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Instructors: " + ex.Message);
            }
        }

        private void StudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InsCombo.SelectedValue is int selected_id)
            {
                var Instructro = db.Instructors.FirstOrDefault(I => I.Id == selected_id);
                if (Instructro != null)
                {
                    first_name.Text = Instructro.FirstName;
                    last_name.Text = Instructro.LastName;
                    phone.Text = Instructro.Phone;
                    deptid.Text = Instructro.DepartmentId.ToString();
                }
            }
        }
    }
}
