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
    public partial class DeleteInsForm : Form
    {

        EF_ProjectContext db = new EF_ProjectContext();
        public DeleteInsForm()
        {
            InitializeComponent();
        }

        private void DeleteInsForm_Load(object sender, EventArgs e)
        {
            LoadInstructorIds();
        }
        private void LoadInstructorIds()
        {
            try
            {
                var Instructors = db.Instructors.Select(I => new { ID = I.Id }).ToList();

                InsCombo.DataSource = Instructors;
                InsCombo.ValueMember = "ID";
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

        private void back_Click(object sender, EventArgs e)
        {
            InstructorForm frm = new InstructorForm();
            frm.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (var transaction = db.Database.BeginTransaction()) 
            {
                try
                {
                    int InstructorId = Convert.ToInt32(InsCombo.SelectedValue);

                   
                    var relatedSessions = db.CourseSessions.Where(cs => cs.InstructorID == InstructorId).ToList();
                    if (relatedSessions.Any())
                    {
                        db.CourseSessions.RemoveRange(relatedSessions);
                        db.SaveChanges();
                    }

                    
                    var relatedCourses = db.Courses.Where(c => c.InstructorID == InstructorId).ToList();
                    if (relatedCourses.Any())
                    {
                        db.Courses.RemoveRange(relatedCourses);
                        db.SaveChanges();
                    }

                    
                    var relatedDepartments = db.Departments.Where(d => d.ManagerID == InstructorId).ToList();
                    if (relatedDepartments.Any())
                    {
                        db.Departments.RemoveRange(relatedDepartments);
                        db.SaveChanges();
                    }

                    
                    var Instructor = db.Instructors.FirstOrDefault(I => I.Id == InstructorId);
                    if (Instructor != null)
                    {
                        db.Instructors.Remove(Instructor);
                        db.SaveChanges();
                        MessageBox.Show("Instructor deleted successfully!");

                        
                        transaction.Commit();

                        
                        LoadInstructorIds();
                    }
                    else
                    {
                        MessageBox.Show("Instructor not found!");
                    }
                }
                catch (Exception ex)
                {
                    
                    transaction.Rollback();
                    MessageBox.Show("Error deleting Instructor: " + (ex.InnerException?.Message ?? ex.Message));
                }
            }
        }
        private void InsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InsCombo.SelectedValue != null && int.TryParse(InsCombo.SelectedValue.ToString(), out int selected_id))
            {
                var Instructor = db.Instructors.FirstOrDefault(I => I.Id == selected_id);
                if (Instructor != null)
                {
                    first_name.Text = Instructor.FirstName;
                    last_name.Text = Instructor.LastName;
                    phone.Text = Instructor.Phone;
                    deptid.Text = Instructor.DepartmentId.ToString();
                }
            }
        }
    }
}
