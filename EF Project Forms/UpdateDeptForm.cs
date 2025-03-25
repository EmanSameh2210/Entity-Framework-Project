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

namespace EF_Project_Forms
{
    public partial class UpdateDeptForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public UpdateDeptForm()
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptCombo.SelectedValue is int selected_id)
                {
                    var Dept = db.Departments.FirstOrDefault(c => c.ID == selected_id);

                    if (Dept != null)
                    {
                        Dept.Name = dept_name.Text;
                        Dept.Location = deptlocation.Text;
                        Dept.ManagerID = int.Parse(mgrid.Text);
                        

                        db.SaveChanges();

                        MessageBox.Show("Manager updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Manegar not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        
        private void LoadManagers()
        {
            try
            {
                var dept = db.Departments.Select(c => new { ID = c.ID }).ToList();

                DeptCombo.DataSource = dept;
                DeptCombo.DisplayMember = "ID";
                DeptCombo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void UpdateDeptForm_Load(object sender, EventArgs e)
        {
            LoadManagers();

        }
        private void DeptCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeptCombo.SelectedValue is int selected_id)
            {
                var dept = db.Departments.FirstOrDefault(c => c.ID == selected_id);
                if (dept != null)
                {
                    dept_name.Text = dept.Name;
                    deptlocation.Text = dept.Location;
                    mgrid.Text = dept.ManagerID.ToString();
                    
                }
            }

        }

        
    }
}
