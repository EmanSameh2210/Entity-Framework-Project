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
using EF_Project_Forms;


namespace EF_Project_Forms
{
    public partial class loadcourseForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public loadcourseForm()
        {
            InitializeComponent();
        }

        private void loadcoursebtn_Click(object sender, EventArgs e)
        {
            db.Courses.Load();

            Gloadcourse.DataSource = db.Courses.Local.ToBindingList();
        }

        private void Insertcoursebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void loadcourseForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Close();
        }
    }
}
