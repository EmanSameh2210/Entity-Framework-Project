using System;
using System.Linq;
using System.Windows.Forms;
using EF_Project_Forms.Context;

namespace EF_Project_Forms
{
    public partial class DeleteStudentForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();

        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Close();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentIDs();
        }

        private void LoadStudentIDs()
        {
            try
            {
                var students = db.Students
                                .Select(s => new { ID = s.ID})
                                .ToList();

                StudentCombo.DataSource = students;
                StudentCombo.DisplayMember = "ID"; 
                StudentCombo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void StudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (StudentCombo.SelectedValue != null && int.TryParse(StudentCombo.SelectedValue.ToString(), out int selected_id))
            {
                var student = db.Students.FirstOrDefault(c => c.ID == selected_id);
                if (student != null)
                {
                    first_name.Text = student.FirstName;
                    last_name.Text = student.LastName;
                    pho.Text = student.Phone;
                   
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentCombo.SelectedValue != null)
                {
                    int studentId = Convert.ToInt32(StudentCombo.SelectedValue);

                    var attendances = db.CourseSessionAttendances.Where(a => a.StudentID == studentId);
                    db.CourseSessionAttendances.RemoveRange(attendances);

                    var student = db.Students.FirstOrDefault(s => s.ID == studentId);

                    if (student != null)
                    {
                        db.Students.Remove(student);
                        db.SaveChanges();
                        MessageBox.Show("Student deleted successfully!");

                        LoadStudentIDs();

                    }
                    else
                    {
                        MessageBox.Show("Student not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}