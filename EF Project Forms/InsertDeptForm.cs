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
using EF_Project_Forms.Models;

namespace EF_Project_Forms
{
    public partial class InsertDeptForm : Form
    {
        EF_ProjectContext context = new EF_ProjectContext();
        public InsertDeptForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            DeptForm deptForm = new DeptForm();
            deptForm.Show();
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                

                var dept = new Department
                {

                    Name = deptname.Text,
                    Location = deptlocation.Text,
                   
                   
                };


                context.Departments.Add(dept);


                context.SaveChanges();

                MessageBox.Show("Department added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void InsertDeptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
