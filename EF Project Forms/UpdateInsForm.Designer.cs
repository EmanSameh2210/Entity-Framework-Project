namespace EF_Project_Forms
{
    partial class UpdateInsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInsForm));
            btn_exit = new Button();
            Row_affected = new Label();
            btn_Update = new Button();
            phone = new TextBox();
            deptid = new TextBox();
            last_name = new TextBox();
            first_name = new TextBox();
            label1 = new Label();
            Address = new Label();
            LastName = new Label();
            FirstName = new Label();
            InsCombo = new ComboBox();
            InsId = new Label();
            back = new Button();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 255, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(571, 309);
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
            btn_Update.Location = new Point(64, 309);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(182, 54);
            btn_Update.TabIndex = 45;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // phone
            // 
            phone.Location = new Point(364, 236);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Name = "phone";
            phone.Size = new Size(199, 23);
            phone.TabIndex = 44;
            // 
            // deptid
            // 
            deptid.Location = new Point(364, 202);
            deptid.Margin = new Padding(3, 2, 3, 2);
            deptid.Name = "deptid";
            deptid.Size = new Size(199, 23);
            deptid.TabIndex = 43;
            // 
            // last_name
            // 
            last_name.Location = new Point(364, 168);
            last_name.Margin = new Padding(3, 2, 3, 2);
            last_name.Name = "last_name";
            last_name.Size = new Size(199, 23);
            last_name.TabIndex = 42;
            // 
            // first_name
            // 
            first_name.Location = new Point(364, 130);
            first_name.Margin = new Padding(3, 2, 3, 2);
            first_name.Name = "first_name";
            first_name.Size = new Size(199, 23);
            first_name.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(165, 234);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 54;
            label1.Text = "Phone";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.FromArgb(192, 255, 255);
            Address.Location = new Point(165, 200);
            Address.Name = "Address";
            Address.Size = new Size(182, 32);
            Address.TabIndex = 53;
            Address.Text = "Department Id";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.FromArgb(192, 255, 255);
            LastName.Location = new Point(165, 166);
            LastName.Name = "LastName";
            LastName.Size = new Size(133, 32);
            LastName.TabIndex = 52;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(192, 255, 255);
            FirstName.Location = new Point(165, 130);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(137, 32);
            FirstName.TabIndex = 51;
            FirstName.Text = "First Name";
            // 
            // InsCombo
            // 
            InsCombo.FormattingEnabled = true;
            InsCombo.Location = new Point(357, 52);
            InsCombo.Name = "InsCombo";
            InsCombo.Size = new Size(206, 23);
            InsCombo.TabIndex = 67;
            InsCombo.SelectedIndexChanged += StudentCombo_SelectedIndexChanged;
            // 
            // InsId
            // 
            InsId.AutoSize = true;
            InsId.BackColor = Color.Transparent;
            InsId.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsId.ForeColor = Color.FromArgb(0, 64, 64);
            InsId.Location = new Point(165, 38);
            InsId.Name = "InsId";
            InsId.Size = new Size(177, 37);
            InsId.TabIndex = 66;
            InsId.Text = "Instructor Id";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(322, 309);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 54);
            back.TabIndex = 68;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // UpdateInsForm
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
            Controls.Add(btn_Update);
            Controls.Add(phone);
            Controls.Add(deptid);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Name = "UpdateInsForm";
            Text = "UpdateInsForm";
            Load += UpdateInsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exit;
        private Label Row_affected;
        private Button btn_Update;
        private TextBox phone;
        private TextBox deptid;
        private TextBox last_name;
        private TextBox first_name;
        private Label label1;
        private Label Address;
        private Label LastName;
        private Label FirstName;
        private ComboBox InsCombo;
        private Label InsId;
        private Button back;
    }
}