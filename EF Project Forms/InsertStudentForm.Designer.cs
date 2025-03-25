namespace EF_Project_Forms
{
    partial class InsertStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertStudentForm));
            back = new Button();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_insert = new Button();
            phone = new TextBox();
            last_name = new TextBox();
            first_name = new TextBox();
            Address = new Label();
            LastName = new Label();
            FirstName = new Label();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 128);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(316, 299);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(180, 46);
            back.TabIndex = 51;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 128, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(555, 299);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(180, 46);
            btn_exit.TabIndex = 48;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Green;
            Row_affected.Location = new Point(462, 323);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 47;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(128, 255, 128);
            btn_insert.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_insert.Location = new Point(65, 299);
            btn_insert.Margin = new Padding(3, 2, 3, 2);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(180, 46);
            btn_insert.TabIndex = 46;
            btn_insert.Text = "Insert ";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // phone
            // 
            phone.Location = new Point(405, 206);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Name = "phone";
            phone.Size = new Size(182, 23);
            phone.TabIndex = 45;
            // 
            // last_name
            // 
            last_name.Location = new Point(405, 172);
            last_name.Margin = new Padding(3, 2, 3, 2);
            last_name.Name = "last_name";
            last_name.Size = new Size(182, 23);
            last_name.TabIndex = 44;
            // 
            // first_name
            // 
            first_name.Location = new Point(405, 138);
            first_name.Margin = new Padding(3, 2, 3, 2);
            first_name.Name = "first_name";
            first_name.Size = new Size(182, 23);
            first_name.TabIndex = 43;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.FromArgb(192, 255, 255);
            Address.Location = new Point(189, 197);
            Address.Name = "Address";
            Address.Size = new Size(86, 32);
            Address.TabIndex = 42;
            Address.Text = "Phone";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.FromArgb(192, 255, 255);
            LastName.Location = new Point(189, 163);
            LastName.Name = "LastName";
            LastName.Size = new Size(133, 32);
            LastName.TabIndex = 41;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(192, 255, 255);
            FirstName.Location = new Point(189, 127);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(137, 32);
            FirstName.TabIndex = 40;
            FirstName.Text = "First Name";
            // 
            // InsertStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_insert);
            Controls.Add(phone);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(Address);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Name = "InsertStudentForm";
            Text = "InsertStudentForm";
            Load += InsertStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_insert;
        private TextBox phone;
        private TextBox last_name;
        private TextBox first_name;
        private Label Address;
        private Label LastName;
        private Label FirstName;
    }
}