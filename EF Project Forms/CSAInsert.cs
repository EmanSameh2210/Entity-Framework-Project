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
    public partial class CSAInsert : Form
    {
        EF_ProjectContext context = new EF_ProjectContext();
        public CSAInsert()
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

                var CSA = new CourseSessionAttendance
                {

                    Grade = int.Parse(grade.Text),
                    Notes = notes.Text,
                    StudentID = int.Parse(sid.Text),
                    CourseSessionId = int.Parse(csid.Text),
                };


                context.CourseSessionAttendances.Add(CSA);


                context.SaveChanges();

                MessageBox.Show("Course Session Attendance added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
