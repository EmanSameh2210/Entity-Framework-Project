namespace EF_Project_Forms
{
    partial class DeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeptForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backbtn = new Button();
            deletedept = new Button();
            updatedept = new Button();
            Insertdept = new Button();
            loaddept = new Button();
            exitbtn = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(479, 124);
            label3.Name = "label3";
            label3.Size = new Size(48, 32);
            label3.TabIndex = 30;
            label3.Text = "😊";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(48, 124);
            label2.Name = "label2";
            label2.Size = new Size(425, 32);
            label2.TabIndex = 29;
            label2.Text = " on this table and see how it works! ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(48, 70);
            label1.Name = "label1";
            label1.Size = new Size(493, 32);
            label1.TabIndex = 28;
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
            backbtn.Location = new Point(79, 446);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(216, 54);
            backbtn.TabIndex = 27;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += exitbtn_Click;
            // 
            // deletedept
            // 
            deletedept.BackColor = Color.FromArgb(255, 255, 192);
            deletedept.FlatAppearance.BorderColor = Color.White;
            deletedept.FlatAppearance.BorderSize = 0;
            deletedept.FlatAppearance.MouseDownBackColor = Color.Silver;
            deletedept.FlatAppearance.MouseOverBackColor = Color.White;
            deletedept.FlatStyle = FlatStyle.Flat;
            deletedept.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            deletedept.ForeColor = Color.FromArgb(64, 64, 64);
            deletedept.Location = new Point(659, 445);
            deletedept.Name = "deletedept";
            deletedept.Size = new Size(216, 54);
            deletedept.TabIndex = 26;
            deletedept.Text = "Delete Department";
            deletedept.UseVisualStyleBackColor = false;
            deletedept.Click += deletedept_Click;
            // 
            // updatedept
            // 
            updatedept.BackColor = Color.FromArgb(216, 175, 157);
            updatedept.FlatAppearance.BorderColor = Color.White;
            updatedept.FlatAppearance.BorderSize = 0;
            updatedept.FlatAppearance.MouseDownBackColor = Color.Silver;
            updatedept.FlatAppearance.MouseOverBackColor = Color.White;
            updatedept.FlatStyle = FlatStyle.Flat;
            updatedept.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            updatedept.ForeColor = Color.FromArgb(64, 64, 64);
            updatedept.Location = new Point(659, 353);
            updatedept.Name = "updatedept";
            updatedept.Size = new Size(216, 54);
            updatedept.TabIndex = 25;
            updatedept.Text = "Update Department";
            updatedept.UseVisualStyleBackColor = false;
            updatedept.Click += updatedept_Click;
            // 
            // Insertdept
            // 
            Insertdept.BackColor = Color.FromArgb(192, 255, 192);
            Insertdept.FlatAppearance.BorderColor = Color.White;
            Insertdept.FlatAppearance.BorderSize = 0;
            Insertdept.FlatAppearance.MouseDownBackColor = Color.Silver;
            Insertdept.FlatAppearance.MouseOverBackColor = Color.White;
            Insertdept.FlatStyle = FlatStyle.Flat;
            Insertdept.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Insertdept.ForeColor = Color.FromArgb(64, 64, 64);
            Insertdept.Location = new Point(659, 255);
            Insertdept.Name = "Insertdept";
            Insertdept.Size = new Size(216, 54);
            Insertdept.TabIndex = 24;
            Insertdept.Text = "Insert Depatment";
            Insertdept.UseVisualStyleBackColor = false;
            Insertdept.Click += Insertdept_Click;
            // 
            // loaddept
            // 
            loaddept.BackColor = Color.FromArgb(255, 192, 192);
            loaddept.FlatAppearance.BorderColor = Color.White;
            loaddept.FlatAppearance.BorderSize = 0;
            loaddept.FlatAppearance.MouseDownBackColor = Color.Silver;
            loaddept.FlatAppearance.MouseOverBackColor = Color.White;
            loaddept.FlatStyle = FlatStyle.Flat;
            loaddept.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            loaddept.ForeColor = Color.FromArgb(64, 64, 64);
            loaddept.Location = new Point(659, 161);
            loaddept.Name = "loaddept";
            loaddept.Size = new Size(216, 54);
            loaddept.TabIndex = 23;
            loaddept.Text = "Load Departments";
            loaddept.UseVisualStyleBackColor = false;
            loaddept.Click += loaddept_Click;
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
            exitbtn.Location = new Point(417, 426);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(216, 54);
            exitbtn.TabIndex = 31;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += button1_Click;
            // 
            // DeptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(934, 661);
            Controls.Add(exitbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backbtn);
            Controls.Add(deletedept);
            Controls.Add(updatedept);
            Controls.Add(Insertdept);
            Controls.Add(loaddept);
            Name = "DeptForm";
            Text = "DeptForm";
            Load += DeptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button backbtn;
        private Button deletedept;
        private Button updatedept;
        private Button Insertdept;
        private Button loaddept;
        private Button exitbtn;
    }
}