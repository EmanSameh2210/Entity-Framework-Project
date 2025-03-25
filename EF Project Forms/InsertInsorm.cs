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
using Microsoft.EntityFrameworkCore;

namespace EF_Project_Forms
{
    public partial class InsertInsorm : Form
    {
        EF_ProjectContext db = new EF_ProjectContext();
        public InsertInsorm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                var Instructor = new Instructor
                {

                    FirstName = txtIns_fname.Text,
                    LastName = txtInsLname.Text,
                    DepartmentId = int.Parse(txtDeptId.Text),
                    Phone = txtInsphone.Text,
                };


                db.Instructors.Add(Instructor);


                db.SaveChanges();

                MessageBox.Show("Instructor added successfully!");
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Database Error: " + dbEx.InnerException?.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertInsorm_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            InstructorForm form = new InstructorForm();
            form.Show();
            this.Close();
        }
    }
}
