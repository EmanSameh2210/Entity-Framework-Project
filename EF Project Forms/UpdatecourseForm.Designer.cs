namespace EF_Project_Forms.Course_CRUD
{
    partial class UpdatecourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatecourseForm));
            btn_exit = new Button();
            Row_affected = new Label();
            btn_Update = new Button();
            txtDeptId = new TextBox();
            course_duration = new TextBox();
            course_name = new TextBox();
            Address = new Label();
            LastName = new Label();
            FirstName = new Label();
            ID = new Label();
            back = new Button();
            txtinstructorId = new TextBox();
            label1 = new Label();
            CourseCombo = new ComboBox();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 128, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(542, 306);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(182, 54);
            btn_exit.TabIndex = 47;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Green;
            Row_affected.Location = new Point(469, 322);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 46;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(255, 128, 255);
            btn_Update.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_Update.Location = new Point(63, 306);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(182, 54);
            btn_Update.TabIndex = 45;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // txtDeptId
            // 
            txtDeptId.Location = new Point(359, 205);
            txtDeptId.Margin = new Padding(3, 2, 3, 2);
            txtDeptId.Name = "txtDeptId";
            txtDeptId.Size = new Size(199, 23);
            txtDeptId.TabIndex = 44;
            // 
            // course_duration
            // 
            course_duration.Location = new Point(359, 171);
            course_duration.Margin = new Padding(3, 2, 3, 2);
            course_duration.Name = "course_duration";
            course_duration.Size = new Size(199, 23);
            course_duration.TabIndex = 43;
            // 
            // course_name
            // 
            course_name.Location = new Point(359, 137);
            course_name.Margin = new Padding(3, 2, 3, 2);
            course_name.Name = "course_name";
            course_name.Size = new Size(199, 23);
            course_name.TabIndex = 42;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.Teal;
            Address.Location = new Point(143, 196);
            Address.Name = "Address";
            Address.Size = new Size(182, 32);
            Address.TabIndex = 40;
            Address.Text = "Departmant Id";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.Teal;
            LastName.Location = new Point(143, 162);
            LastName.Name = "LastName";
            LastName.Size = new Size(202, 32);
            LastName.TabIndex = 39;
            LastName.Text = "Course Duration";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.Teal;
            FirstName.Location = new Point(143, 128);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(167, 32);
            FirstName.TabIndex = 38;
            FirstName.Text = "Course Name";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.Transparent;
            ID.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.ForeColor = Color.FromArgb(0, 64, 64);
            ID.Location = new Point(187, 58);
            ID.Name = "ID";
            ID.Size = new Size(138, 37);
            ID.TabIndex = 37;
            ID.Text = "Course Id";
            ID.Click += ID_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(310, 306);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 54);
            back.TabIndex = 48;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += button1_Click;
            // 
            // txtinstructorId
            // 
            txtinstructorId.Location = new Point(359, 242);
            txtinstructorId.Margin = new Padding(3, 2, 3, 2);
            txtinstructorId.Name = "txtinstructorId";
            txtinstructorId.Size = new Size(199, 23);
            txtinstructorId.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(143, 233);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 49;
            label1.Text = "Instructor Id";
            // 
            // CourseCombo
            // 
            CourseCombo.FormattingEnabled = true;
            CourseCombo.Location = new Point(352, 72);
            CourseCombo.Name = "CourseCombo";
            CourseCombo.Size = new Size(206, 23);
            CourseCombo.TabIndex = 51;
            CourseCombo.SelectedIndexChanged += CourseCombo_SelectedIndexChanged;
            // 
            // UpdatecourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(CourseCombo);
            Controls.Add(txtinstructorId);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_Update);
            Controls.Add(txtDeptId);
            Controls.Add(course_duration);
            Controls.Add(course_name);
            Controls.Add(Address);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(ID);
            Name = "UpdatecourseForm";
            Text = "UpdatecourseForm";
            Load += UpdatecourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exit;
        private Label Row_affected;
        private Button btn_Update;
        private TextBox txtDeptId;
        private TextBox course_duration;
        private TextBox course_name;
        private Label Address;
        private Label LastName;
        private Label FirstName;
        private Label ID;
        private Button back;
        private TextBox txtinstructorId;
        private Label label1;
        private ComboBox CourseCombo;
    }
}