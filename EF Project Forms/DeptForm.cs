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
    public partial class DeptForm : Form
    {
        //public EventHandler DeptForm_Shown { get; private set; }

        public DeptForm()
        {
            InitializeComponent();

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void loaddept_Click(object sender, EventArgs e)
        {
            LoadDeptForm loadDeptForm = new LoadDeptForm();
            loadDeptForm.Show();
            this.Close();
        }

        private void Insertdept_Click(object sender, EventArgs e)
        {
            InsertDeptForm insertDeptForm = new InsertDeptForm();
            insertDeptForm.Show();
            this.Close();
        }

        private void updatedept_Click(object sender, EventArgs e)
        {
            UpdateDeptForm updateDeptForm = new UpdateDeptForm();
            updateDeptForm.Show();
            this.Close();
        }

        private void deletedept_Click(object sender, EventArgs e)
        {
            DeleteDeptForm deleteDeptForm = new DeleteDeptForm();
            deleteDeptForm.Show();
            this.Close();
        }

        private void DeptForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
