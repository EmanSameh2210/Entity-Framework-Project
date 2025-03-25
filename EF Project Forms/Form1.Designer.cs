namespace EF_Project_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            MngDept = new Button();
            MngStud = new Button();
            MngCrsSess = new Button();
            MngIns = new Button();
            MngCS = new Button();
            MngCSA = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(34, 56);
            label1.Name = "label1";
            label1.Size = new Size(597, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome! 😊 Manage your data effortlessly. ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(34, 100);
            label2.Name = "label2";
            label2.Size = new Size(370, 37);
            label2.TabIndex = 1;
            label2.Text = "Enjoy a smooth experience!";
            // 
            // MngDept
            // 
            MngDept.BackColor = Color.FromArgb(255, 192, 192);
            MngDept.FlatAppearance.BorderColor = Color.White;
            MngDept.FlatAppearance.BorderSize = 0;
            MngDept.FlatAppearance.MouseDownBackColor = Color.Silver;
            MngDept.FlatAppearance.MouseOverBackColor = Color.White;
            MngDept.FlatStyle = FlatStyle.Flat;
            MngDept.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            MngDept.ForeColor = Color.FromArgb(64, 64, 64);
            MngDept.Location = new Point(636, 39);
            MngDept.Name = "MngDept";
            MngDept.Size = new Size(269, 54);
            MngDept.TabIndex = 2;
            MngDept.Text = "Managge Department";
            MngDept.UseVisualStyleBackColor = false;
            MngDept.Click += MngDept_Click;
            // 
            // MngStud
            // 
            MngStud.BackColor = Color.FromArgb(192, 255, 192);
            MngStud.FlatAppearance.BorderColor = Color.White;
            MngStud.FlatAppearance.BorderSize = 0;
            MngStud.FlatAppearance.MouseDownBackColor = Color.Silver;
            MngStud.FlatAppearance.MouseOverBackColor = Color.White;
            MngStud.FlatStyle = FlatStyle.Flat;
            MngStud.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            MngStud.ForeColor = Color.FromArgb(64, 64, 64);
            MngStud.Location = new Point(636, 124);
            MngStud.Name = "MngStud";
            MngStud.Size = new Size(269, 54);
            MngStud.TabIndex = 3;
            MngStud.Text = "Managge Students";
            MngStud.UseVisualStyleBackColor = false;
            MngStud.Click += MngStud_Click;
            // 
            // MngCrsSess
            // 
            MngCrsSess.BackColor = Color.FromArgb(216, 175, 157);
            MngCrsSess.FlatAppearance.BorderColor = Color.White;
            MngCrsSess.FlatAppearance.BorderSize = 0;
            MngCrsSess.FlatAppearance.MouseDownBackColor = Color.Silver;
            MngCrsSess.FlatAppearance.MouseOverBackColor = Color.White;
            MngCrsSess.FlatStyle = FlatStyle.Flat;
            MngCrsSess.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            MngCrsSess.ForeColor = Color.FromArgb(64, 64, 64);
            MngCrsSess.Location = new Point(636, 213);
            MngCrsSess.Name = "MngCrsSess";
            MngCrsSess.Size = new Size(269, 54);
            MngCrsSess.TabIndex = 4;
            MngCrsSess.Text = " Manage Courses";
            MngCrsSess.UseVisualStyleBackColor = false;
            MngCrsSess.Click += MngCrsSess_Click;
            // 
            // MngIns
            // 
            MngIns.BackColor = Color.FromArgb(255, 255, 192);
            MngIns.FlatAppearance.BorderColor = Color.White;
            MngIns.FlatAppearance.BorderSize = 0;
            MngIns.FlatAppearance.MouseDownBackColor = Color.Silver;
            MngIns.FlatAppearance.MouseOverBackColor = Color.White;
            MngIns.FlatStyle = FlatStyle.Flat;
            MngIns.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            MngIns.ForeColor = Color.FromArgb(64, 64, 64);
            MngIns.Location = new Point(636, 299);
            MngIns.Name = "MngIns";
            MngIns.Size = new Size(269, 54);
            MngIns.TabIndex = 5;
            MngIns.Text = "Managge Instructors";
            MngIns.UseVisualStyleBackColor = false;
            MngIns.Click += MngIns_Click;
            // 
            // MngCS
            // 
            MngCS.BackColor = Color.FromArgb(192, 255, 255);
            MngCS.FlatAppearance.BorderColor = Color.White;
            MngCS.FlatAppearance.BorderSize = 0;
            MngCS.FlatAppearance.MouseDownBackColor = Color.Silver;
            MngCS.FlatAppearance.MouseOverBackColor = Color.White;
            MngCS.FlatStyle = FlatStyle.Flat;
            MngCS.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            MngCS.ForeColor = Color.FromArgb(64, 64, 64);
            MngCS.Location = new Point(636, 384);
            MngCS.Name = "MngCS";
            MngCS.Size = new Size(269, 54);
            MngCS.TabIndex = 6;
            MngCS.Text = "Managge Course Session";
            MngCS.UseVisualStyleBackColor = false;
            MngCS.Click += MngCS_Click;
            // 
            // MngCSA
            // 
            MngCSA.BackColor = Color.FromArgb(192, 192, 255);
            MngCSA.FlatAppearance.BorderColor = Color.White;
            MngCSA.FlatAppearance.BorderSize = 0;
            MngCSA.FlatAppearance.MouseDownBackColor = Color.Silver;
            MngCSA.FlatAppearance.MouseOverBackColor = Color.White;
            MngCSA.FlatStyle = FlatStyle.Flat;
            MngCSA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            MngCSA.ForeColor = Color.FromArgb(64, 64, 64);
            MngCSA.Location = new Point(636, 469);
            MngCSA.Name = "MngCSA";
            MngCSA.Size = new Size(269, 54);
            MngCSA.TabIndex = 7;
            MngCSA.Text = "Managge Courses Session Attendanse";
            MngCSA.UseVisualStyleBackColor = false;
            MngCSA.Click += MngCSA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(934, 561);
            Controls.Add(MngCSA);
            Controls.Add(MngCS);
            Controls.Add(MngIns);
            Controls.Add(MngCrsSess);
            Controls.Add(MngStud);
            Controls.Add(MngDept);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Manage Enrollment";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button MngDept;
        private Button MngStud;
        private Button MngCrsSess;
        private Button MngIns;
        private Button MngCS;
        private Button MngCSA;
    }
}
