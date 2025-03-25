namespace EF_Project_Forms
{
    partial class CourseSessionAttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseSessionAttendanceForm));
            exitbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backbtn = new Button();
            deletecoursebtn = new Button();
            updatecoursebtn = new Button();
            Insertcoursebtn = new Button();
            loadcoursebtn = new Button();
            SuspendLayout();
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.FromArgb(255, 128, 128);
            exitbtn.FlatAppearance.BorderColor = Color.White;
            exitbtn.FlatAppearance.BorderSize = 0;
            exitbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            exitbtn.FlatAppearance.MouseOverBackColor = Color.White;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            exitbtn.ForeColor = Color.FromArgb(64, 64, 64);
            exitbtn.Location = new Point(323, 447);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(151, 54);
            exitbtn.TabIndex = 50;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(495, 125);
            label3.Name = "label3";
            label3.Size = new Size(48, 32);
            label3.TabIndex = 49;
            label3.Text = "😊";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(64, 125);
            label2.Name = "label2";
            label2.Size = new Size(425, 32);
            label2.TabIndex = 48;
            label2.Text = " on this table and see how it works! ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(64, 71);
            label1.Name = "label1";
            label1.Size = new Size(493, 32);
            label1.TabIndex = 47;
            label1.Text = "You can try performing CRUD operations ";
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.FromArgb(192, 255, 255);
            backbtn.FlatAppearance.BorderColor = Color.White;
            backbtn.FlatAppearance.BorderSize = 0;
            backbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            backbtn.FlatAppearance.MouseOverBackColor = Color.White;
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            backbtn.ForeColor = Color.FromArgb(64, 64, 64);
            backbtn.Location = new Point(45, 447);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(151, 54);
            backbtn.TabIndex = 46;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // deletecoursebtn
            // 
            deletecoursebtn.BackColor = Color.FromArgb(255, 255, 192);
            deletecoursebtn.FlatAppearance.BorderColor = Color.White;
            deletecoursebtn.FlatAppearance.BorderSize = 0;
            deletecoursebtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            deletecoursebtn.FlatAppearance.MouseOverBackColor = Color.White;
            deletecoursebtn.FlatStyle = FlatStyle.Flat;
            deletecoursebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            deletecoursebtn.ForeColor = Color.FromArgb(64, 64, 64);
            deletecoursebtn.Location = new Point(588, 425);
            deletecoursebtn.Name = "deletecoursebtn";
            deletecoursebtn.Size = new Size(334, 54);
            deletecoursebtn.TabIndex = 45;
            deletecoursebtn.Text = "Delete Course Session Attendance";
            deletecoursebtn.UseVisualStyleBackColor = false;
            deletecoursebtn.Click += deletecoursebtn_Click;
            // 
            // updatecoursebtn
            // 
            updatecoursebtn.BackColor = Color.FromArgb(216, 175, 157);
            updatecoursebtn.FlatAppearance.BorderColor = Color.White;
            updatecoursebtn.FlatAppearance.BorderSize = 0;
            updatecoursebtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            updatecoursebtn.FlatAppearance.MouseOverBackColor = Color.White;
            updatecoursebtn.FlatStyle = FlatStyle.Flat;
            updatecoursebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            updatecoursebtn.ForeColor = Color.FromArgb(64, 64, 64);
            updatecoursebtn.Location = new Point(588, 333);
            updatecoursebtn.Name = "updatecoursebtn";
            updatecoursebtn.Size = new Size(334, 54);
            updatecoursebtn.TabIndex = 44;
            updatecoursebtn.Text = "Update Course Session Attendance";
            updatecoursebtn.UseVisualStyleBackColor = false;
            updatecoursebtn.Click += updatecoursebtn_Click;
            // 
            // Insertcoursebtn
            // 
            Insertcoursebtn.BackColor = Color.FromArgb(192, 255, 192);
            Insertcoursebtn.FlatAppearance.BorderColor = Color.White;
            Insertcoursebtn.FlatAppearance.BorderSize = 0;
            Insertcoursebtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            Insertcoursebtn.FlatAppearance.MouseOverBackColor = Color.White;
            Insertcoursebtn.FlatStyle = FlatStyle.Flat;
            Insertcoursebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Insertcoursebtn.ForeColor = Color.FromArgb(64, 64, 64);
            Insertcoursebtn.Location = new Point(588, 235);
            Insertcoursebtn.Name = "Insertcoursebtn";
            Insertcoursebtn.Size = new Size(334, 54);
            Insertcoursebtn.TabIndex = 43;
            Insertcoursebtn.Text = "Insert Course Session Attendance";
            Insertcoursebtn.UseVisualStyleBackColor = false;
            Insertcoursebtn.Click += Insertcoursebtn_Click;
            // 
            // loadcoursebtn
            // 
            loadcoursebtn.BackColor = Color.FromArgb(255, 192, 192);
            loadcoursebtn.FlatAppearance.BorderColor = Color.White;
            loadcoursebtn.FlatAppearance.BorderSize = 0;
            loadcoursebtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            loadcoursebtn.FlatAppearance.MouseOverBackColor = Color.White;
            loadcoursebtn.FlatStyle = FlatStyle.Flat;
            loadcoursebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            loadcoursebtn.ForeColor = Color.FromArgb(64, 64, 64);
            loadcoursebtn.Location = new Point(588, 141);
            loadcoursebtn.Name = "loadcoursebtn";
            loadcoursebtn.Size = new Size(334, 54);
            loadcoursebtn.TabIndex = 42;
            loadcoursebtn.Text = "Load Courses Session Attendance";
            loadcoursebtn.UseVisualStyleBackColor = false;
            loadcoursebtn.Click += loadcoursebtn_Click;
            // 
            // CourseSessionAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(934, 561);
            Controls.Add(exitbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backbtn);
            Controls.Add(deletecoursebtn);
            Controls.Add(updatecoursebtn);
            Controls.Add(Insertcoursebtn);
            Controls.Add(loadcoursebtn);
            Name = "CourseSessionAttendanceForm";
            Text = "CourseSessionAttendanceForm";
            Load += CourseSessionAttendanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitbtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button backbtn;
        private Button deletecoursebtn;
        private Button updatecoursebtn;
        private Button Insertcoursebtn;
        private Button loadcoursebtn;
    }
}