using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Project_Forms.Context;
using EF_Project_Forms.Course_CRUD;


namespace EF_Project_Forms
{
    public partial class CourseForm : Form
    {

        public CourseForm()
        {
            InitializeComponent();
            this.Shown += new System.EventHandler(this.CourseForm_Shown);
        }
        private void MakeButtonRound(Button btn)
        {
            btn.Width = 250;
            btn.Height = 80;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void CourseForm_Shown(object sender, EventArgs e)
        {
            MakeButtonRound(loadcoursebtn);
            MakeButtonRound(Insertcoursebtn);
            MakeButtonRound(updatecoursebtn);
            MakeButtonRound(deletecoursebtn);
            MakeButtonRound(backbtn);
            MakeButtonRound(exitbtn);


        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void loadcoursebtn_Click(object sender, EventArgs e)
        {
            loadcourseForm loadcourseForm = new loadcourseForm();
            loadcourseForm.Show();
            this.Close();

        }

        private void Insertcoursebtn_Click(object sender, EventArgs e)
        {
            insertcourseForm insertcourseForm = new insertcourseForm();
            insertcourseForm.Show();
            this.Close();
        }

        private void updatecoursebtn_Click(object sender, EventArgs e)
        {
            UpdatecourseForm updatecourseForm = new UpdatecourseForm();
            updatecourseForm.Show();
            this.Close();
        }

        private void deletecoursebtn_Click(object sender, EventArgs e)
        {
            DeletecourseForm deletecourseForm = new DeletecourseForm();
            deletecourseForm.Show();
            this.Close();
        }

        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
