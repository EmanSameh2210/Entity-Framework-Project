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
    public partial class LoadDeptForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public LoadDeptForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            DeptForm deptForm = new DeptForm();
            deptForm.Show();
            this.Close();

        }

        private void Insertcoursebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GloadDept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loaddeptbtn_Click(object sender, EventArgs e)
        {
            db.Departments.Load();

            GloadDept.DataSource = db.Departments.Local.ToBindingList();
        }
    }
}
