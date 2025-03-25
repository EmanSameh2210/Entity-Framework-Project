namespace EF_Project_Forms.Course_CRUD
{
    partial class DeletecourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletecourseForm));
            btn_exit = new Button();
            Row_affected = new Label();
            btn_Delete = new Button();
            ID = new Label();
            back = new Button();
            CourseCombo = new ComboBox();
            txtinstructorId = new TextBox();
            label1 = new Label();
            txtDeptId = new TextBox();
            course_duration = new TextBox();
            course_name = new TextBox();
            Address = new Label();
            LastName = new Label();
            FirstName = new Label();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(128, 255, 255);
            btn_exit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn_exit.ForeColor = Color.Black;
            btn_exit.Location = new Point(576, 287);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(180, 47);
            btn_exit.TabIndex = 52;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Black;
            Row_affected.Location = new Point(490, 325);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 25);
            Row_affected.TabIndex = 51;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(255, 128, 128);
            btn_Delete.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.Black;
            btn_Delete.Location = new Point(71, 292);
            btn_Delete.Margin = new Padding(3, 2, 3, 2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(179, 47);
            btn_Delete.TabIndex = 50;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.Transparent;
            ID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.ForeColor = Color.FromArgb(128, 255, 255);
            ID.Location = new Point(182, 64);
            ID.Name = "ID";
            ID.Size = new Size(123, 32);
            ID.TabIndex = 48;
            ID.Text = "Course Id";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(327, 292);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 47);
            back.TabIndex = 53;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // CourseCombo
            // 
            CourseCombo.FormattingEnabled = true;
            CourseCombo.Location = new Point(327, 73);
            CourseCombo.Name = "CourseCombo";
            CourseCombo.Size = new Size(206, 23);
            CourseCombo.TabIndex = 54;
            CourseCombo.SelectedIndexChanged += CourseCombo_SelectedIndexChanged;
            // 
            // txtinstructorId
            // 
            txtinstructorId.Location = new Point(398, 234);
            txtinstructorId.Margin = new Padding(3, 2, 3, 2);
            txtinstructorId.Name = "txtinstructorId";
            txtinstructorId.Size = new Size(199, 23);
            txtinstructorId.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(182, 225);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 61;
            label1.Text = "Instructor Id";
            // 
            // txtDeptId
            // 
            txtDeptId.Location = new Point(398, 197);
            txtDeptId.Margin = new Padding(3, 2, 3, 2);
            txtDeptId.Name = "txtDeptId";
            txtDeptId.Size = new Size(199, 23);
            txtDeptId.TabIndex = 60;
            // 
            // course_duration
            // 
            course_duration.Location = new Point(398, 163);
            course_duration.Margin = new Padding(3, 2, 3, 2);
            course_duration.Name = "course_duration";
            course_duration.Size = new Size(199, 23);
            course_duration.TabIndex = 59;
            // 
            // course_name
            // 
            course_name.Location = new Point(398, 129);
            course_name.Margin = new Padding(3, 2, 3, 2);
            course_name.Name = "course_name";
            course_name.Size = new Size(199, 23);
            course_name.TabIndex = 58;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.FromArgb(128, 255, 255);
            Address.Location = new Point(182, 188);
            Address.Name = "Address";
            Address.Size = new Size(182, 32);
            Address.TabIndex = 57;
            Address.Text = "Departmant Id";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.FromArgb(128, 255, 255);
            LastName.Location = new Point(182, 154);
            LastName.Name = "LastName";
            LastName.Size = new Size(202, 32);
            LastName.TabIndex = 56;
            LastName.Text = "Course Duration";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(128, 255, 255);
            FirstName.Location = new Point(182, 120);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(167, 32);
            FirstName.TabIndex = 55;
            FirstName.Text = "Course Name";
            // 
            // DeletecourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(txtinstructorId);
            Controls.Add(label1);
            Controls.Add(txtDeptId);
            Controls.Add(course_duration);
            Controls.Add(course_name);
            Controls.Add(Address);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(CourseCombo);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_Delete);
            Controls.Add(ID);
            Name = "DeletecourseForm";
            Text = "DeletecourseForm";
            Load += DeletecourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exit;
        private Label Row_affected;
        private Button btn_Delete;
        private Label ID;
        private Button back;
        private ComboBox CourseCombo;
        private TextBox txtinstructorId;
        private Label label1;
        private TextBox txtDeptId;
        private TextBox course_duration;
        private TextBox course_name;
        private Label Address;
        private Label LastName;
        private Label FirstName;
    }
}