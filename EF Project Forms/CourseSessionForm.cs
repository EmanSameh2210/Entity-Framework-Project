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
    public partial class CourseSessionForm : Form
    {
        public CourseSessionForm()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void ssbtn_Click(object sender, EventArgs e)
        {
            LoadCourseSessionForm courseSessionForm = new LoadCourseSessionForm();
            courseSessionForm.Show();
            this.Close();
        }

        private void Insertss_Click(object sender, EventArgs e)
        {
            InsertCourseSessionForm courseSessionForm = new InsertCourseSessionForm();
            courseSessionForm.Show();
            this.Close();
        }

        private void updatess_Click(object sender, EventArgs e)
        {
            UpdateCourseSessionForm courseSessionForm = new UpdateCourseSessionForm();
            courseSessionForm.Show();
            this.Close();
        }

        private void deletess_Click(object sender, EventArgs e)
        {
            DeleteCourseSessionForm courseSessionForm = new DeleteCourseSessionForm();
            courseSessionForm.Show();
            this.Close();
        }
    }
}
