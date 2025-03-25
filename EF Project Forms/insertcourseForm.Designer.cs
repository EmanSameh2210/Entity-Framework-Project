namespace EF_Project_Forms.Course_CRUD
{
    partial class insertcourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertcourseForm));
            btn_exit = new Button();
            Row_affected = new Label();
            btn_insert = new Button();
            txtDeptId = new TextBox();
            course_duration = new TextBox();
            course_name = new TextBox();
            Address = new Label();
            LastName = new Label();
            FirstName = new Label();
            label1 = new Label();
            txtInsId = new TextBox();
            back = new Button();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 128, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(563, 303);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(180, 46);
            btn_exit.TabIndex = 36;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Green;
            Row_affected.Location = new Point(470, 327);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 35;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(128, 255, 128);
            btn_insert.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_insert.Location = new Point(73, 303);
            btn_insert.Margin = new Padding(3, 2, 3, 2);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(180, 46);
            btn_insert.TabIndex = 34;
            btn_insert.Text = "Insert ";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // txtDeptId
            // 
            txtDeptId.Location = new Point(423, 181);
            txtDeptId.Margin = new Padding(3, 2, 3, 2);
            txtDeptId.Name = "txtDeptId";
            txtDeptId.Size = new Size(182, 23);
            txtDeptId.TabIndex = 33;
            // 
            // course_duration
            // 
            course_duration.Location = new Point(423, 147);
            course_duration.Margin = new Padding(3, 2, 3, 2);
            course_duration.Name = "course_duration";
            course_duration.Size = new Size(182, 23);
            course_duration.TabIndex = 32;
            // 
            // course_name
            // 
            course_name.Location = new Point(423, 113);
            course_name.Margin = new Padding(3, 2, 3, 2);
            course_name.Name = "course_name";
            course_name.Size = new Size(182, 23);
            course_name.TabIndex = 31;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.FromArgb(192, 255, 255);
            Address.Location = new Point(207, 172);
            Address.Name = "Address";
            Address.Size = new Size(182, 32);
            Address.TabIndex = 29;
            Address.Text = "Department Id";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.FromArgb(192, 255, 255);
            LastName.Location = new Point(207, 138);
            LastName.Name = "LastName";
            LastName.Size = new Size(202, 32);
            LastName.TabIndex = 28;
            LastName.Text = "Course Duration";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(192, 255, 255);
            FirstName.Location = new Point(207, 102);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(167, 32);
            FirstName.TabIndex = 27;
            FirstName.Text = "Course Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(207, 206);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 37;
            label1.Text = "Instructor Id";
            label1.Click += label1_Click;
            // 
            // txtInsId
            // 
            txtInsId.Location = new Point(423, 215);
            txtInsId.Margin = new Padding(3, 2, 3, 2);
            txtInsId.Name = "txtInsId";
            txtInsId.Size = new Size(182, 23);
            txtInsId.TabIndex = 38;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 128);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(324, 303);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(180, 46);
            back.TabIndex = 39;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // insertcourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(txtInsId);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_insert);
            Controls.Add(txtDeptId);
            Controls.Add(course_duration);
            Controls.Add(course_name);
            Controls.Add(Address);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Name = "insertcourseForm";
            Text = "insertcourseForm";
            Load += insertcourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exit;
        private Label Row_affected;
        private Button btn_insert;
        private TextBox txtDeptId;
        private TextBox course_duration;
        private TextBox course_name;
        private Label Address;
        private Label LastName;
        private Label FirstName;
        private Label label1;
        private TextBox txtInsId;
        private Button back;
    }
}