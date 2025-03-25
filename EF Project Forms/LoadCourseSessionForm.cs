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
    public partial class LoadCourseSessionForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public LoadCourseSessionForm()
        {
            InitializeComponent();
        }

        private void Insertcoursebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CourseSessionForm frm = new CourseSessionForm();
            frm.Show();
            this.Close();
        }

        private void LoadCourseSessionForm_Load(object sender, EventArgs e)
        {

        }

        private void loadcoursebtn_Click(object sender, EventArgs e)
        {
            db.CourseSessions.Load();

           GloadSS.DataSource = db.CourseSessions.Local.ToBindingList();
        }
    }
}
