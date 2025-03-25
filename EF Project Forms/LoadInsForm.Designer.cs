namespace EF_Project_Forms
{
    partial class LoadInsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadInsForm));
            Insertcoursebtn = new Button();
            loadInsbtn = new Button();
            GloadIns = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)GloadIns).BeginInit();
            SuspendLayout();
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
            Insertcoursebtn.Location = new Point(554, 365);
            Insertcoursebtn.Name = "Insertcoursebtn";
            Insertcoursebtn.Size = new Size(216, 54);
            Insertcoursebtn.TabIndex = 13;
            Insertcoursebtn.Text = "Exit";
            Insertcoursebtn.UseVisualStyleBackColor = false;
            Insertcoursebtn.Click += Insertcoursebtn_Click;
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
            loadInsbtn.Location = new Point(31, 365);
            loadInsbtn.Name = "loadInsbtn";
            loadInsbtn.Size = new Size(216, 54);
            loadInsbtn.TabIndex = 12;
            loadInsbtn.Text = "Load ";
            loadInsbtn.UseVisualStyleBackColor = false;
            loadInsbtn.Click += loadInsbtn_Click;
            // 
            // GloadIns
            // 
            GloadIns.BackgroundColor = Color.FromArgb(156, 163, 157);
            GloadIns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GloadIns.Location = new Point(12, 32);
            GloadIns.Name = "GloadIns";
            GloadIns.Size = new Size(776, 280);
            GloadIns.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(294, 365);
            button1.Name = "button1";
            button1.Size = new Size(216, 54);
            button1.TabIndex = 14;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoadInsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Insertcoursebtn);
            Controls.Add(loadInsbtn);
            Controls.Add(GloadIns);
            Name = "LoadInsForm";
            Text = "LoadInsForm";
            Load += LoadInsForm_Load;
            ((System.ComponentModel.ISupportInitialize)GloadIns).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Insertcoursebtn;
        private Button loadInsbtn;
        private DataGridView GloadIns;
        private Button button1;
    }
}