using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project_Forms
{
    public partial class CourseSessionAttendanceForm : Form
    {
        public CourseSessionAttendanceForm()
        {
            InitializeComponent();
            this.Shown += new System.EventHandler(this.CourseForm_Shown);
        }

        private void CourseSessionAttendanceForm_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadcoursebtn_Click(object sender, EventArgs e)
        {
            CSALoad course = new CSALoad();
            course.Show();
            this.Close();
        }

        private void Insertcoursebtn_Click(object sender, EventArgs e)
        {
            CSAInsert course = new CSAInsert();
            course.Show();
            this.Close();
        }

        private void updatecoursebtn_Click(object sender, EventArgs e)
        {
            CSAUpdate cSAUpdate = new CSAUpdate();
            cSAUpdate.Show();
            this.Close();
        }

        private void deletecoursebtn_Click(object sender, EventArgs e)
        {
            CSADelete cSADelete = new CSADelete();
            cSADelete.Show();
            this.Close();
        }

        private void MakeButtonRound(Button btn)
        {
            btn.Width = 250;
            btn.Height = 80;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
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
    }
}
