namespace EF_Project_Forms
{
    partial class DeleteStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudentForm));
            pho = new TextBox();
            last_name = new TextBox();
            first_name = new TextBox();
            phone = new Label();
            LastName = new Label();
            FirstName = new Label();
            StudentCombo = new ComboBox();
            back = new Button();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_Delete = new Button();
            studentid = new Label();
            SuspendLayout();
            // 
            // pho
            // 
            pho.Location = new Point(385, 215);
            pho.Margin = new Padding(3, 2, 3, 2);
            pho.Name = "pho";
            pho.Size = new Size(199, 23);
            pho.TabIndex = 74;
            // 
            // last_name
            // 
            last_name.Location = new Point(385, 181);
            last_name.Margin = new Padding(3, 2, 3, 2);
            last_name.Name = "last_name";
            last_name.Size = new Size(199, 23);
            last_name.TabIndex = 73;
            // 
            // first_name
            // 
            first_name.Location = new Point(385, 147);
            first_name.Margin = new Padding(3, 2, 3, 2);
            first_name.Name = "first_name";
            first_name.Size = new Size(199, 23);
            first_name.TabIndex = 72;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = Color.Transparent;
            phone.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            phone.ForeColor = Color.FromArgb(128, 255, 255);
            phone.Location = new Point(169, 206);
            phone.Name = "phone";
            phone.Size = new Size(86, 32);
            phone.TabIndex = 71;
            phone.Text = "Phone";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.FromArgb(128, 255, 255);
            LastName.Location = new Point(169, 172);
            LastName.Name = "LastName";
            LastName.Size = new Size(124, 32);
            LastName.TabIndex = 70;
            LastName.Text = "last name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(128, 255, 255);
            FirstName.Location = new Point(169, 138);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(137, 32);
            FirstName.TabIndex = 69;
            FirstName.Text = "First Name";
            // 
            // StudentCombo
            // 
            StudentCombo.FormattingEnabled = true;
            StudentCombo.Location = new Point(314, 91);
            StudentCombo.Name = "StudentCombo";
            StudentCombo.Size = new Size(206, 23);
            StudentCombo.TabIndex = 68;
            StudentCombo.SelectedIndexChanged += StudentCombo_SelectedIndexChanged;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(314, 310);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 47);
            back.TabIndex = 67;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(128, 255, 255);
            btn_exit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn_exit.ForeColor = Color.Black;
            btn_exit.Location = new Point(563, 305);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(180, 47);
            btn_exit.TabIndex = 66;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Black;
            Row_affected.Location = new Point(477, 343);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 25);
            Row_affected.TabIndex = 65;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(255, 128, 128);
            btn_Delete.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.Black;
            btn_Delete.Location = new Point(58, 310);
            btn_Delete.Margin = new Padding(3, 2, 3, 2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(179, 47);
            btn_Delete.TabIndex = 64;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // studentid
            // 
            studentid.AutoSize = true;
            studentid.BackColor = Color.Transparent;
            studentid.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentid.ForeColor = Color.FromArgb(128, 255, 255);
            studentid.Location = new Point(169, 82);
            studentid.Name = "studentid";
            studentid.Size = new Size(132, 32);
            studentid.TabIndex = 63;
            studentid.Text = "Student Id";
            // 
            // DeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(pho);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(phone);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(StudentCombo);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_Delete);
            Controls.Add(studentid);
            Name = "DeleteStudentForm";
            Text = "DeleteStudentForm";
            Load += DeleteStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pho;
        private TextBox last_name;
        private TextBox first_name;
        private Label phone;
        private Label LastName;
        private Label FirstName;
        private ComboBox StudentCombo;
        private Button back;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_Delete;
        private Label studentid;
    }
}