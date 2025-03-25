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
    public partial class DeleteDeptForm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public DeleteDeptForm()
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

        //private void btn_Update_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (DeptCombo.SelectedValue is int selected_id)
        //        {
        //            var Dept = db.Departments.FirstOrDefault(c => c.ID == selected_id);

        //            if (Dept != null)
        //            {

        //                Dept.Name = dept_name.Text;
        //                Dept.Location = deptlocation.Text;
        //                //Dept.ManagerID = int.Parse(mgrid.Text);
        //                if (int.TryParse(mgrid.Text, out int managerID))
        //                {
        //                    Dept.ManagerID = managerID;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Please enter a valid Manager ID.");
        //                    return;
        //                }

        //                db.SaveChanges();

        //                MessageBox.Show("Department Deleted successfully!");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Department not found!");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void LoadDepts()
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
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }



        private void DeleteDeptForm_Load_1(object sender, EventArgs e)
        {
            LoadDepts();
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptCombo.SelectedValue != null && int.TryParse(DeptCombo.SelectedValue.ToString(), out int selected_id))
                {
                    var dept = db.Departments.FirstOrDefault(c => c.ID == selected_id);

                    if (dept != null)
                    {

                            db.Departments.Remove(dept);
                            db.SaveChanges();

                            MessageBox.Show("Department deleted successfully!");

                            
                            LoadDepts();
                        
                    }
                    else
                    {
                        MessageBox.Show("Department not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
