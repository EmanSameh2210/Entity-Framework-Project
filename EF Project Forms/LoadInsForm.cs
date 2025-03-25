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
    public partial class LoadInsForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public LoadInsForm()
        {
            InitializeComponent();
        }

        private void Insertcoursebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void loadInsbtn_Click(object sender, EventArgs e)
        {
            db.Instructors.Load();

            GloadIns.DataSource = db.Instructors.Local.ToBindingList();
        }

        private void LoadInsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstructorForm instructorForm = new InstructorForm();
            instructorForm.Show();
            this.Close();
        }
    }
}
