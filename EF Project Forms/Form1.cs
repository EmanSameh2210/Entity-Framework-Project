using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace EF_Project_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += new System.EventHandler(this.Form1_Shown);
        }

        private void MakeButtonRound(Button btn)
        {
            btn.Width = 250;
            btn.Height = 80;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            MakeButtonRound(MngDept);
            MakeButtonRound(MngIns);
            MakeButtonRound(MngStud);
            MakeButtonRound(MngCSA);
            MakeButtonRound(MngCrsSess);
            MakeButtonRound(MngCS);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MngCrsSess_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Hide();

        }

        private void MngDept_Click(object sender, EventArgs e)
        {
            DeptForm deptForm = new DeptForm();
            deptForm.Show();
            this.Hide();
        }

        private void MngStud_Click(object sender, EventArgs e)
        {
            StudentForm studForm = new StudentForm();
            studForm.Show();
            this.Hide();
        }

        private void MngIns_Click(object sender, EventArgs e)
        {
            InstructorForm insForm = new InstructorForm();
            insForm.Show();
            this.Hide();
        }

        private void MngCS_Click(object sender, EventArgs e)
        {
            CourseSessionForm courseSessionForm = new CourseSessionForm();
            courseSessionForm.Show();
            this.Hide();
        }

        private void MngCSA_Click(object sender, EventArgs e)
        {
            CourseSessionAttendanceForm courseSessionAttendanceForm = new CourseSessionAttendanceForm();
            courseSessionAttendanceForm.Show();
            this.Hide();
        }
    }
}
