namespace EF_Project_Forms
{
    partial class LoadDeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadDeptForm));
            back = new Button();
            Insertcoursebtn = new Button();
            loaddeptbtn = new Button();
            GloadDept = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GloadDept).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.ForeColor = Color.FromArgb(64, 64, 64);
            back.Location = new Point(303, 364);
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
            Insertcoursebtn.Location = new Point(529, 365);
            Insertcoursebtn.Name = "Insertcoursebtn";
            Insertcoursebtn.Size = new Size(216, 54);
            Insertcoursebtn.TabIndex = 52;
            Insertcoursebtn.Text = "Exit";
            Insertcoursebtn.UseVisualStyleBackColor = false;
            Insertcoursebtn.Click += Insertcoursebtn_Click;
            // 
            // loaddeptbtn
            // 
            loaddeptbtn.BackColor = Color.FromArgb(255, 192, 192);
            loaddeptbtn.FlatAppearance.BorderColor = Color.White;
            loaddeptbtn.FlatAppearance.BorderSize = 0;
            loaddeptbtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            loaddeptbtn.FlatAppearance.MouseOverBackColor = Color.White;
            loaddeptbtn.FlatStyle = FlatStyle.Flat;
            loaddeptbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            loaddeptbtn.ForeColor = Color.FromArgb(64, 64, 64);
            loaddeptbtn.Location = new Point(48, 365);
            loaddeptbtn.Name = "loaddeptbtn";
            loaddeptbtn.Size = new Size(216, 54);
            loaddeptbtn.TabIndex = 51;
            loaddeptbtn.Text = "Load ";
            loaddeptbtn.UseVisualStyleBackColor = false;
            loaddeptbtn.Click += loaddeptbtn_Click;
            // 
            // GloadDept
            // 
            GloadDept.BackgroundColor = Color.FromArgb(156, 163, 157);
            GloadDept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GloadDept.Location = new Point(12, 32);
            GloadDept.Name = "GloadDept";
            GloadDept.Size = new Size(776, 280);
            GloadDept.TabIndex = 50;
            GloadDept.CellContentClick += GloadDept_CellContentClick;
            // 
            // LoadDeptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(Insertcoursebtn);
            Controls.Add(loaddeptbtn);
            Controls.Add(GloadDept);
            Name = "LoadDeptForm";
            Text = "LoadDeptForm";
            ((System.ComponentModel.ISupportInitialize)GloadDept).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Button Insertcoursebtn;
        private Button loaddeptbtn;
        private DataGridView GloadDept;
    }
}