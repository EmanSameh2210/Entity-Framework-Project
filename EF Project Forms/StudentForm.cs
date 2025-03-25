using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project_Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void loadcoursebtn_Click(object sender, EventArgs e)
        {
            LoadStudentForm studentForm = new LoadStudentForm();
            studentForm.Show();
            this.Close();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insertstudentbtn_Click(object sender, EventArgs e)
        {
            InsertStudentForm studentForm = new InsertStudentForm();
            studentForm.Show();
            this.Close();
        }

        private void updatestudentbtn_Click(object sender, EventArgs e)
        {
            UpdateStudentForm studentForm = new UpdateStudentForm();
            studentForm.Show();
            this.Close();
        }

        private void deletestudentbtn_Click(object sender, EventArgs e)
        {
            DeleteStudentForm deleteStudentForm = new DeleteStudentForm();
            deleteStudentForm.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
