namespace EF_Project_Forms
{
    partial class LoadStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadStudentForm));
            back = new Button();
            Insertcoursebtn = new Button();
            loadstudentbtn = new Button();
            GLoadStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GLoadStudent).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.ForeColor = Color.FromArgb(64, 64, 64);
            back.Location = new Point(326, 355);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 54);
            back.TabIndex = 53;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // Insertcoursebtn
            // 
            Insertcoursebtn.BackColor = Color.FromArgb(255, 128, 128);
            Insertcoursebtn.FlatAppearance.BorderColor = Color.White;
            Insertcoursebtn.FlatAppearance.BorderSize = 0;
            Insertcoursebtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            Insertcoursebtn.FlatAppearance.MouseOverBackColor = Color.White;
            Insertcoursebtn.FlatStyle = FlatStyle.Flat;
            Insertcoursebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Insertcoursebtn.ForeColor = Color.FromArgb(64, 64, 64);
            Insertcoursebtn.Location = new Point(562, 355);
            Insertcoursebtn.Name = "Insertcoursebtn";
            Insertcoursebtn.Size = new Size(181, 54);
            Insertcoursebtn.TabIndex = 52;
            Insertcoursebtn.Text = "Exit";
            Insertcoursebtn.UseVisualStyleBackColor = false;
            Insertcoursebtn.Click += Insertcoursebtn_Click;
            // 
            // loadstudentbtn
            // 
            loadstudentbtn.BackColor = Color.FromArgb(255, 192, 192);
            loadstudentbtn.FlatAppearance.BorderColor = Color.White;
            loadstudentbtn.FlatAppearance.BorderSize = 0;
            loadstudentbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            loadstudentbtn.FlatAppearance.MouseOverBackColor = Color.White;
            loadstudentbtn.FlatStyle = FlatStyle.Flat;
            loadstudentbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            loadstudentbtn.ForeColor = Color.FromArgb(64, 64, 64);
            loadstudentbtn.Location = new Point(105, 356);
            loadstudentbtn.Name = "loadstudentbtn";
            loadstudentbtn.Size = new Size(182, 54);
            loadstudentbtn.TabIndex = 51;
            loadstudentbtn.Text = "Load ";
            loadstudentbtn.UseVisualStyleBackColor = false;
            loadstudentbtn.Click += loadcoursebtn_Click;
            // 
            // GLoadStudent
            // 
            GLoadStudent.BackgroundColor = Color.FromArgb(156, 163, 157);
            GLoadStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GLoadStudent.Location = new Point(60, 21);
            GLoadStudent.Name = "GLoadStudent";
            GLoadStudent.Size = new Size(698, 305);
            GLoadStudent.TabIndex = 50;
            GLoadStudent.CellContentClick += Gloadcourse_CellContentClick;
            // 
            // LoadStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(Insertcoursebtn);
            Controls.Add(loadstudentbtn);
            Controls.Add(GLoadStudent);
            Name = "LoadStudentForm";
            Text = "LoadStudentForm";
            Load += LoadStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)GLoadStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Button Insertcoursebtn;
        private Button loadstudentbtn;
        private DataGridView GLoadStudent;
    }
}