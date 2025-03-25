namespace EF_Project_Forms
{
    partial class UpdateDeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDeptForm));
            DeptCombo = new ComboBox();
            back = new Button();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_Update = new Button();
            mgrid = new TextBox();
            deptlocation = new TextBox();
            dept_name = new TextBox();
            Address = new Label();
            LastName = new Label();
            deptName = new Label();
            ID = new Label();
            SuspendLayout();
            // 
            // DeptCombo
            // 
            DeptCombo.FormattingEnabled = true;
            DeptCombo.Location = new Point(359, 88);
            DeptCombo.Name = "DeptCombo";
            DeptCombo.Size = new Size(206, 23);
            DeptCombo.TabIndex = 65;
            DeptCombo.SelectedIndexChanged += DeptCombo_SelectedIndexChanged;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(317, 322);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 54);
            back.TabIndex = 62;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 128, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(549, 322);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(182, 54);
            btn_exit.TabIndex = 61;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Green;
            Row_affected.Location = new Point(476, 338);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 60;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(255, 128, 255);
            btn_Update.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_Update.Location = new Point(70, 322);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(182, 54);
            btn_Update.TabIndex = 59;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // mgrid
            // 
            mgrid.Location = new Point(366, 221);
            mgrid.Margin = new Padding(3, 2, 3, 2);
            mgrid.Name = "mgrid";
            mgrid.Size = new Size(199, 23);
            mgrid.TabIndex = 58;
            // 
            // deptlocation
            // 
            deptlocation.Location = new Point(366, 187);
            deptlocation.Margin = new Padding(3, 2, 3, 2);
            deptlocation.Name = "deptlocation";
            deptlocation.Size = new Size(199, 23);
            deptlocation.TabIndex = 57;
            // 
            // dept_name
            // 
            dept_name.Location = new Point(366, 153);
            dept_name.Margin = new Padding(3, 2, 3, 2);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(199, 23);
            dept_name.TabIndex = 56;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.Teal;
            Address.Location = new Point(150, 212);
            Address.Name = "Address";
            Address.Size = new Size(146, 32);
            Address.TabIndex = 55;
            Address.Text = "Maneger Id";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.Teal;
            LastName.Location = new Point(150, 178);
            LastName.Name = "LastName";
            LastName.Size = new Size(112, 32);
            LastName.TabIndex = 54;
            LastName.Text = "Location";
            // 
            // deptName
            // 
            deptName.AutoSize = true;
            deptName.BackColor = Color.Transparent;
            deptName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            deptName.ForeColor = Color.Teal;
            deptName.Location = new Point(150, 144);
            deptName.Name = "deptName";
            deptName.Size = new Size(88, 32);
            deptName.TabIndex = 53;
            deptName.Text = " Name";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.Transparent;
            ID.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.ForeColor = Color.FromArgb(0, 64, 64);
            ID.Location = new Point(150, 74);
            ID.Name = "ID";
            ID.Size = new Size(207, 37);
            ID.TabIndex = 52;
            ID.Text = "Department Id";
            // 
            // UpdateDeptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(DeptCombo);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_Update);
            Controls.Add(mgrid);
            Controls.Add(deptlocation);
            Controls.Add(dept_name);
            Controls.Add(Address);
            Controls.Add(LastName);
            Controls.Add(deptName);
            Controls.Add(ID);
            Name = "UpdateDeptForm";
            Text = "UpdateDeptForm";
            Load += UpdateDeptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DeptCombo;
        private Button back;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_Update;
        private TextBox mgrid;
        private TextBox deptlocation;
        private TextBox dept_name;
        private Label Address;
        private Label LastName;
        private Label deptName;
        private Label ID;
    }
}