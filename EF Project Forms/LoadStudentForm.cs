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
using Microsoft.EntityFrameworkCore;

namespace EF_Project_Forms
{
    public partial class LoadStudentForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public LoadStudentForm()
        {
            InitializeComponent();
        }

        private void Insertcoursebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Close();
        }

        private void Gloadcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void loadcoursebtn_Click(object sender, EventArgs e)
        {
            db.Students.Load();

            GLoadStudent.DataSource = db.Students.Local.ToBindingList();
        }
    }
}
