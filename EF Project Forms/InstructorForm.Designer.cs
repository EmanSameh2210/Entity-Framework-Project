namespace EF_Project_Forms
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            exit = new Button();
            deleteInsbtn = new Button();
            updatInsbtn = new Button();
            InsertInsbtn = new Button();
            loadInsbtn = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(477, 111);
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
            label2.Location = new Point(46, 111);
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
            label1.Location = new Point(46, 57);
            label1.Name = "label1";
            label1.Size = new Size(493, 32);
            label1.TabIndex = 20;
            label1.Text = "You can try performing CRUD operations ";
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
            exit.Location = new Point(365, 428);
            exit.Name = "exit";
            exit.Size = new Size(216, 54);
            exit.TabIndex = 19;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exitbtn_Click;
            // 
            // deleteInsbtn
            // 
            deleteInsbtn.BackColor = Color.FromArgb(255, 255, 192);
            deleteInsbtn.FlatAppearance.BorderColor = Color.White;
            deleteInsbtn.FlatAppearance.BorderSize = 0;
            deleteInsbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            deleteInsbtn.FlatAppearance.MouseOverBackColor = Color.White;
            deleteInsbtn.FlatStyle = FlatStyle.Flat;
            deleteInsbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            deleteInsbtn.ForeColor = Color.FromArgb(64, 64, 64);
            deleteInsbtn.Location = new Point(651, 428);
            deleteInsbtn.Name = "deleteInsbtn";
            deleteInsbtn.Size = new Size(216, 54);
            deleteInsbtn.TabIndex = 18;
            deleteInsbtn.Text = "Delete Instructor";
            deleteInsbtn.UseVisualStyleBackColor = false;
            deleteInsbtn.Click += deleteInsbtn_Click;
            // 
            // updatInsbtn
            // 
            updatInsbtn.BackColor = Color.FromArgb(216, 175, 157);
            updatInsbtn.FlatAppearance.BorderColor = Color.White;
            updatInsbtn.FlatAppearance.BorderSize = 0;
            updatInsbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            updatInsbtn.FlatAppearance.MouseOverBackColor = Color.White;
            updatInsbtn.FlatStyle = FlatStyle.Flat;
            updatInsbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            updatInsbtn.ForeColor = Color.FromArgb(64, 64, 64);
            updatInsbtn.Location = new Point(651, 336);
            updatInsbtn.Name = "updatInsbtn";
            updatInsbtn.Size = new Size(216, 54);
            updatInsbtn.TabIndex = 17;
            updatInsbtn.Text = "Update Instructor";
            updatInsbtn.UseVisualStyleBackColor = false;
            updatInsbtn.Click += updatInsbtn_Click;
            // 
            // InsertInsbtn
            // 
            InsertInsbtn.BackColor = Color.FromArgb(192, 255, 192);
            InsertInsbtn.FlatAppearance.BorderColor = Color.White;
            InsertInsbtn.FlatAppearance.BorderSize = 0;
            InsertInsbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            InsertInsbtn.FlatAppearance.MouseOverBackColor = Color.White;
            InsertInsbtn.FlatStyle = FlatStyle.Flat;
            InsertInsbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            InsertInsbtn.ForeColor = Color.FromArgb(64, 64, 64);
            InsertInsbtn.Location = new Point(651, 238);
            InsertInsbtn.Name = "InsertInsbtn";
            InsertInsbtn.Size = new Size(216, 54);
            InsertInsbtn.TabIndex = 16;
            InsertInsbtn.Text = "Insert Instructor";
            InsertInsbtn.UseVisualStyleBackColor = false;
            InsertInsbtn.Click += InsertInsbtn_Click;
            // 
            // loadInsbtn
            // 
            loadInsbtn.BackColor = Color.FromArgb(255, 192, 192);
            loadInsbtn.FlatAppearance.BorderColor = Color.White;
            loadInsbtn.FlatAppearance.BorderSize = 0;
            loadInsbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            loadInsbtn.FlatAppearance.MouseOverBackColor = Color.White;
            loadInsbtn.FlatStyle = FlatStyle.Flat;
            loadInsbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            loadInsbtn.ForeColor = Color.FromArgb(64, 64, 64);
            loadInsbtn.Location = new Point(651, 144);
            loadInsbtn.Name = "loadInsbtn";
            loadInsbtn.Size = new Size(216, 54);
            loadInsbtn.TabIndex = 15;
            loadInsbtn.Text = "Load Instructors";
            loadInsbtn.UseVisualStyleBackColor = false;
            loadInsbtn.Click += loadInsbtn_Click;
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
            back.Location = new Point(91, 428);
            back.Name = "back";
            back.Size = new Size(216, 54);
            back.TabIndex = 23;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(934, 561);
            Controls.Add(back);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(deleteInsbtn);
            Controls.Add(updatInsbtn);
            Controls.Add(InsertInsbtn);
            Controls.Add(loadInsbtn);
            Name = "InstructorForm";
            Text = "InstructorForm";
            Load += InstructorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button exit;
        private Button deleteInsbtn;
        private Button updatInsbtn;
        private Button InsertInsbtn;
        private Button loadInsbtn;
        private Button back;
    }
}