namespace EF_Project_Forms
{
    partial class DeleteInsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteInsForm));
            back = new Button();
            InsCombo = new ComboBox();
            InsId = new Label();
            label1 = new Label();
            Address = new Label();
            LastName = new Label();
            FirstName = new Label();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_delete = new Button();
            phone = new TextBox();
            deptid = new TextBox();
            last_name = new TextBox();
            first_name = new TextBox();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(314, 334);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 54);
            back.TabIndex = 82;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // InsCombo
            // 
            InsCombo.FormattingEnabled = true;
            InsCombo.Location = new Point(349, 77);
            InsCombo.Name = "InsCombo";
            InsCombo.Size = new Size(206, 23);
            InsCombo.TabIndex = 81;
            InsCombo.SelectedIndexChanged += InsCombo_SelectedIndexChanged;
            // 
            // InsId
            // 
            InsId.AutoSize = true;
            InsId.BackColor = Color.Transparent;
            InsId.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsId.ForeColor = Color.FromArgb(0, 64, 64);
            InsId.Location = new Point(157, 63);
            InsId.Name = "InsId";
            InsId.Size = new Size(177, 37);
            InsId.TabIndex = 80;
            InsId.Text = "Instructor Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(157, 259);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 79;
            label1.Text = "Phone";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.FromArgb(192, 255, 255);
            Address.Location = new Point(157, 225);
            Address.Name = "Address";
            Address.Size = new Size(182, 32);
            Address.TabIndex = 78;
            Address.Text = "Department Id";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.FromArgb(192, 255, 255);
            LastName.Location = new Point(157, 191);
            LastName.Name = "LastName";
            LastName.Size = new Size(133, 32);
            LastName.TabIndex = 77;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(192, 255, 255);
            FirstName.Location = new Point(157, 155);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(137, 32);
            FirstName.TabIndex = 76;
            FirstName.Text = "First Name";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 255, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(563, 334);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(182, 54);
            btn_exit.TabIndex = 75;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Green;
            Row_affected.Location = new Point(461, 347);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 74;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 128, 255);
            btn_delete.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_delete.Location = new Point(56, 334);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(182, 54);
            btn_delete.TabIndex = 73;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // phone
            // 
            phone.Location = new Point(356, 261);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Name = "phone";
            phone.Size = new Size(199, 23);
            phone.TabIndex = 72;
            // 
            // deptid
            // 
            deptid.Location = new Point(356, 227);
            deptid.Margin = new Padding(3, 2, 3, 2);
            deptid.Name = "deptid";
            deptid.Size = new Size(199, 23);
            deptid.TabIndex = 71;
            // 
            // last_name
            // 
            last_name.Location = new Point(356, 193);
            last_name.Margin = new Padding(3, 2, 3, 2);
            last_name.Name = "last_name";
            last_name.Size = new Size(199, 23);
            last_name.TabIndex = 70;
            // 
            // first_name
            // 
            first_name.Location = new Point(356, 155);
            first_name.Margin = new Padding(3, 2, 3, 2);
            first_name.Name = "first_name";
            first_name.Size = new Size(199, 23);
            first_name.TabIndex = 69;
            // 
            // DeleteInsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(InsCombo);
            Controls.Add(InsId);
            Controls.Add(label1);
            Controls.Add(Address);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_delete);
            Controls.Add(phone);
            Controls.Add(deptid);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Name = "DeleteInsForm";
            Text = "DeleteInsForm";
            Load += DeleteInsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private ComboBox InsCombo;
        private Label InsId;
        private Label label1;
        private Label Address;
        private Label LastName;
        private Label FirstName;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_delete;
        private TextBox phone;
        private TextBox deptid;
        private TextBox last_name;
        private TextBox first_name;
    }
}