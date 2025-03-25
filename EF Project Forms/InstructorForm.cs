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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
            // this.Shown += new System.EventHandler(this.InsForm_Shown);
        }
        private void MakeButtonRound(Button btn)
        {
            btn.Width = 250;
            btn.Height = 80;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }


        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void InsForm_Shown(object sender, EventArgs e)
        {
            MakeButtonRound(loadInsbtn);
            MakeButtonRound(InsertInsbtn);
            MakeButtonRound(updatInsbtn);
            MakeButtonRound(deleteInsbtn);
            MakeButtonRound(exit);


        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadInsbtn_Click(object sender, EventArgs e)
        {
            LoadInsForm loadInsForm = new LoadInsForm();
            loadInsForm.Show();
            this.Close();
        }

        private void InsertInsbtn_Click(object sender, EventArgs e)
        {
            InsertInsorm insertInsorm = new InsertInsorm();
            insertInsorm.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void updatInsbtn_Click(object sender, EventArgs e)
        {
            UpdateInsForm form = new UpdateInsForm();
            form.Show();
            this.Close();
        }

        private void deleteInsbtn_Click(object sender, EventArgs e)
        {
            DeleteInsForm deleteInsForm = new DeleteInsForm();
            deleteInsForm.Show();
            this.Close();
        }
    }
}
