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
    public partial class CSALoad : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public CSALoad()
        {
            InitializeComponent();
        }

        private void Insertcoursebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CourseSessionAttendanceForm courseSessionAttendanceForm = new CourseSessionAttendanceForm();
            courseSessionAttendanceForm.Show();
            this.Close();
        }

        private void CSALoad_Load(object sender, EventArgs e)
        {

        }

        private void loadcoursebtn_Click(object sender, EventArgs e)
        {
            db.CourseSessionAttendances.Load();

            GloadCSA.DataSource = db.CourseSessionAttendances.Local.ToBindingList();
        }

        private void GloadCSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
