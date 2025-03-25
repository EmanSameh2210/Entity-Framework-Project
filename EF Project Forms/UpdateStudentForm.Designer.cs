namespace EF_Project_Forms
{
    partial class UpdateStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudentForm));
            StudentCombo = new ComboBox();
            back = new Button();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_Update = new Button();
            ph = new TextBox();
            last_name = new TextBox();
            first_name = new TextBox();
            phone = new Label();
            LastName = new Label();
            FirstName = new Label();
            studentid = new Label();
            SuspendLayout();
            // 
            // StudentCombo
            // 
            StudentCombo.FormattingEnabled = true;
            StudentCombo.Location = new Point(359, 88);
            StudentCombo.Name = "StudentCombo";
            StudentCombo.Size = new Size(206, 23);
            StudentCombo.TabIndex = 65;
            StudentCombo.SelectedIndexChanged += StudentCombo_SelectedIndexChanged;
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
            // ph
            // 
            ph.Location = new Point(366, 221);
            ph.Margin = new Padding(3, 2, 3, 2);
            ph.Name = "ph";
            ph.Size = new Size(199, 23);
            ph.TabIndex = 58;
            // 
            // last_name
            // 
            last_name.Location = new Point(366, 187);
            last_name.Margin = new Padding(3, 2, 3, 2);
            last_name.Name = "last_name";
            last_name.Size = new Size(199, 23);
            last_name.TabIndex = 57;
            // 
            // first_name
            // 
            first_name.Location = new Point(366, 153);
            first_name.Margin = new Padding(3, 2, 3, 2);
            first_name.Name = "first_name";
            first_name.Size = new Size(199, 23);
            first_name.TabIndex = 56;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = Color.Transparent;
            phone.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            phone.ForeColor = Color.Teal;
            phone.Location = new Point(150, 212);
            phone.Name = "phone";
            phone.Size = new Size(86, 32);
            phone.TabIndex = 55;
            phone.Text = "Phone";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.Teal;
            LastName.Location = new Point(150, 178);
            LastName.Name = "LastName";
            LastName.Size = new Size(133, 32);
            LastName.TabIndex = 54;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.Teal;
            FirstName.Location = new Point(150, 144);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(137, 32);
            FirstName.TabIndex = 53;
            FirstName.Text = "First Name";
            // 
            // studentid
            // 
            studentid.AutoSize = true;
            studentid.BackColor = Color.Transparent;
            studentid.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentid.ForeColor = Color.FromArgb(0, 64, 64);
            studentid.Location = new Point(194, 74);
            studentid.Name = "studentid";
            studentid.Size = new Size(150, 37);
            studentid.TabIndex = 52;
            studentid.Text = "Student Id";
            // 
            // UpdateStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(StudentCombo);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_Update);
            Controls.Add(ph);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(phone);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(studentid);
            Name = "UpdateStudentForm";
            Text = "UpdateStudentForm";
            Load += UpdateStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox StudentCombo;
        private Button back;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_Update;
        private TextBox ph;
        private TextBox last_name;
        private TextBox first_name;
        private Label phone;
        private Label LastName;
        private Label FirstName;
        private Label studentid;
    }
}