namespace EF_Project_Forms
{
    partial class CourseSessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseSessionForm));
            exitbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backbtn = new Button();
            deletess = new Button();
            updatess = new Button();
            Insertss = new Button();
            ssbtn = new Button();
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
            exitbtn.Location = new Point(323, 434);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(216, 54);
            exitbtn.TabIndex = 41;
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
            label3.Location = new Point(477, 112);
            label3.Name = "label3";
            label3.Size = new Size(48, 32);
            label3.TabIndex = 40;
            label3.Text = "😊";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(46, 112);
            label2.Name = "label2";
            label2.Size = new Size(425, 32);
            label2.TabIndex = 39;
            label2.Text = " on this table and see how it works! ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(46, 58);
            label1.Name = "label1";
            label1.Size = new Size(493, 32);
            label1.TabIndex = 38;
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
            backbtn.Location = new Point(61, 434);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(216, 54);
            backbtn.TabIndex = 37;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // deletess
            // 
            deletess.BackColor = Color.FromArgb(255, 255, 192);
            deletess.FlatAppearance.BorderColor = Color.White;
            deletess.FlatAppearance.BorderSize = 0;
            deletess.FlatAppearance.MouseDownBackColor = Color.Silver;
            deletess.FlatAppearance.MouseOverBackColor = Color.White;
            deletess.FlatStyle = FlatStyle.Flat;
            deletess.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            deletess.ForeColor = Color.FromArgb(64, 64, 64);
            deletess.Location = new Point(623, 432);
            deletess.Name = "deletess";
            deletess.Size = new Size(273, 54);
            deletess.TabIndex = 36;
            deletess.Text = "Delete Course Session";
            deletess.UseVisualStyleBackColor = false;
            deletess.Click += deletess_Click;
            // 
            // updatess
            // 
            updatess.BackColor = Color.FromArgb(216, 175, 157);
            updatess.FlatAppearance.BorderColor = Color.White;
            updatess.FlatAppearance.BorderSize = 0;
            updatess.FlatAppearance.MouseDownBackColor = Color.Silver;
            updatess.FlatAppearance.MouseOverBackColor = Color.White;
            updatess.FlatStyle = FlatStyle.Flat;
            updatess.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            updatess.ForeColor = Color.FromArgb(64, 64, 64);
            updatess.Location = new Point(623, 340);
            updatess.Name = "updatess";
            updatess.Size = new Size(273, 54);
            updatess.TabIndex = 35;
            updatess.Text = "Update Course Session";
            updatess.UseVisualStyleBackColor = false;
            updatess.Click += updatess_Click;
            // 
            // Insertss
            // 
            Insertss.BackColor = Color.FromArgb(192, 255, 192);
            Insertss.FlatAppearance.BorderColor = Color.White;
            Insertss.FlatAppearance.BorderSize = 0;
            Insertss.FlatAppearance.MouseDownBackColor = Color.Silver;
            Insertss.FlatAppearance.MouseOverBackColor = Color.White;
            Insertss.FlatStyle = FlatStyle.Flat;
            Insertss.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Insertss.ForeColor = Color.FromArgb(64, 64, 64);
            Insertss.Location = new Point(623, 242);
            Insertss.Name = "Insertss";
            Insertss.Size = new Size(273, 54);
            Insertss.TabIndex = 34;
            Insertss.Text = "Insert Course Session";
            Insertss.UseVisualStyleBackColor = false;
            Insertss.Click += Insertss_Click;
            // 
            // ssbtn
            // 
            ssbtn.BackColor = Color.FromArgb(255, 192, 192);
            ssbtn.FlatAppearance.BorderColor = Color.White;
            ssbtn.FlatAppearance.BorderSize = 0;
            ssbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            ssbtn.FlatAppearance.MouseOverBackColor = Color.White;
            ssbtn.FlatStyle = FlatStyle.Flat;
            ssbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            ssbtn.ForeColor = Color.FromArgb(64, 64, 64);
            ssbtn.Location = new Point(623, 148);
            ssbtn.Name = "ssbtn";
            ssbtn.Size = new Size(273, 54);
            ssbtn.TabIndex = 33;
            ssbtn.Text = "Load Courses Sessions";
            ssbtn.UseVisualStyleBackColor = false;
            ssbtn.Click += ssbtn_Click;
            // 
            // CourseSessionForm
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
            Controls.Add(deletess);
            Controls.Add(updatess);
            Controls.Add(Insertss);
            Controls.Add(ssbtn);
            Name = "CourseSessionForm";
            Text = "CourseSessionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitbtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button backbtn;
        private Button deletess;
        private Button updatess;
        private Button Insertss;
        private Button ssbtn;
    }
}