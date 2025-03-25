namespace EF_Project_Forms
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            deletestudentbtn = new Button();
            updatestudentbtn = new Button();
            Insertstudentbtn = new Button();
            loadstudentbtn = new Button();
            back = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(452, 110);
            label3.Name = "label3";
            label3.Size = new Size(48, 32);
            label3.TabIndex = 22;
            label3.Text = "😊";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(21, 110);
            label2.Name = "label2";
            label2.Size = new Size(425, 32);
            label2.TabIndex = 21;
            label2.Text = " on this table and see how it works! ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(21, 56);
            label1.Name = "label1";
            label1.Size = new Size(493, 32);
            label1.TabIndex = 20;
            label1.Text = "You can try performing CRUD operations ";
            // 
            // deletestudentbtn
            // 
            deletestudentbtn.BackColor = Color.FromArgb(255, 255, 192);
            deletestudentbtn.FlatAppearance.BorderColor = Color.White;
            deletestudentbtn.FlatAppearance.BorderSize = 0;
            deletestudentbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            deletestudentbtn.FlatAppearance.MouseOverBackColor = Color.White;
            deletestudentbtn.FlatStyle = FlatStyle.Flat;
            deletestudentbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            deletestudentbtn.ForeColor = Color.FromArgb(64, 64, 64);
            deletestudentbtn.Location = new Point(553, 365);
            deletestudentbtn.Name = "deletestudentbtn";
            deletestudentbtn.Size = new Size(216, 54);
            deletestudentbtn.TabIndex = 18;
            deletestudentbtn.Text = "Delete Student";
            deletestudentbtn.UseVisualStyleBackColor = false;
            deletestudentbtn.Click += deletestudentbtn_Click;
            // 
            // updatestudentbtn
            // 
            updatestudentbtn.BackColor = Color.FromArgb(216, 175, 157);
            updatestudentbtn.FlatAppearance.BorderColor = Color.White;
            updatestudentbtn.FlatAppearance.BorderSize = 0;
            updatestudentbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            updatestudentbtn.FlatAppearance.MouseOverBackColor = Color.White;
            updatestudentbtn.FlatStyle = FlatStyle.Flat;
            updatestudentbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            updatestudentbtn.ForeColor = Color.FromArgb(64, 64, 64);
            updatestudentbtn.Location = new Point(553, 273);
            updatestudentbtn.Name = "updatestudentbtn";
            updatestudentbtn.Size = new Size(216, 54);
            updatestudentbtn.TabIndex = 17;
            updatestudentbtn.Text = "Update Student";
            updatestudentbtn.UseVisualStyleBackColor = false;
            updatestudentbtn.Click += updatestudentbtn_Click;
            // 
            // Insertstudentbtn
            // 
            Insertstudentbtn.BackColor = Color.FromArgb(192, 255, 192);
            Insertstudentbtn.FlatAppearance.BorderColor = Color.White;
            Insertstudentbtn.FlatAppearance.BorderSize = 0;
            Insertstudentbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            Insertstudentbtn.FlatAppearance.MouseOverBackColor = Color.White;
            Insertstudentbtn.FlatStyle = FlatStyle.Flat;
            Insertstudentbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Insertstudentbtn.ForeColor = Color.FromArgb(64, 64, 64);
            Insertstudentbtn.Location = new Point(553, 175);
            Insertstudentbtn.Name = "Insertstudentbtn";
            Insertstudentbtn.Size = new Size(216, 54);
            Insertstudentbtn.TabIndex = 16;
            Insertstudentbtn.Text = "Insert Student";
            Insertstudentbtn.UseVisualStyleBackColor = false;
            Insertstudentbtn.Click += Insertstudentbtn_Click;
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
            loadstudentbtn.Location = new Point(553, 81);
            loadstudentbtn.Name = "loadstudentbtn";
            loadstudentbtn.Size = new Size(216, 54);
            loadstudentbtn.TabIndex = 15;
            loadstudentbtn.Text = "Load Students";
            loadstudentbtn.UseVisualStyleBackColor = false;
            loadstudentbtn.Click += loadcoursebtn_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 255);
            back.FlatAppearance.BorderColor = Color.White;
            back.FlatAppearance.BorderSize = 0;
            back.FlatAppearance.MouseDownBackColor = Color.Silver;
            back.FlatAppearance.MouseOverBackColor = Color.White;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            back.ForeColor = Color.FromArgb(64, 64, 64);
            back.Location = new Point(24, 365);
            back.Name = "back";
            back.Size = new Size(216, 54);
            back.TabIndex = 25;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(255, 128, 128);
            exit.FlatAppearance.BorderColor = Color.White;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatAppearance.MouseDownBackColor = Color.Silver;
            exit.FlatAppearance.MouseOverBackColor = Color.White;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            exit.ForeColor = Color.FromArgb(64, 64, 64);
            exit.Location = new Point(298, 365);
            exit.Name = "exit";
            exit.Size = new Size(216, 54);
            exit.TabIndex = 24;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(exit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deletestudentbtn);
            Controls.Add(updatestudentbtn);
            Controls.Add(Insertstudentbtn);
            Controls.Add(loadstudentbtn);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button deletestudentbtn;
        private Button updatestudentbtn;
        private Button Insertstudentbtn;
        private Button loadstudentbtn;
        private Button back;
        private Button exit;
    }
}