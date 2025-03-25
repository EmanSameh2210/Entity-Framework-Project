namespace EF_Project_Forms
{
    partial class InsertInsorm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertInsorm));
            txtInsphone = new TextBox();
            label1 = new Label();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_insert = new Button();
            txtDeptId = new TextBox();
            txtInsLname = new TextBox();
            txtIns_fname = new TextBox();
            Address = new Label();
            LastName = new Label();
            FirstName = new Label();
            back = new Button();
            SuspendLayout();
            // 
            // txtInsphone
            // 
            txtInsphone.Location = new Point(400, 229);
            txtInsphone.Margin = new Padding(3, 2, 3, 2);
            txtInsphone.Name = "txtInsphone";
            txtInsphone.Size = new Size(182, 23);
            txtInsphone.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(184, 220);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 50;
            label1.Text = "Phone";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 128, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.ForeColor = Color.FromArgb(64, 64, 64);
            btn_exit.Location = new Point(570, 324);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(180, 46);
            btn_exit.TabIndex = 49;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.FromArgb(64, 64, 64);
            Row_affected.Location = new Point(447, 341);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 48;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(128, 255, 128);
            btn_insert.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_insert.ForeColor = Color.FromArgb(64, 64, 64);
            btn_insert.Location = new Point(90, 324);
            btn_insert.Margin = new Padding(3, 2, 3, 2);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(180, 46);
            btn_insert.TabIndex = 47;
            btn_insert.Text = "Insert ";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // txtDeptId
            // 
            txtDeptId.Location = new Point(400, 195);
            txtDeptId.Margin = new Padding(3, 2, 3, 2);
            txtDeptId.Name = "txtDeptId";
            txtDeptId.Size = new Size(182, 23);
            txtDeptId.TabIndex = 46;
            // 
            // txtInsLname
            // 
            txtInsLname.Location = new Point(400, 161);
            txtInsLname.Margin = new Padding(3, 2, 3, 2);
            txtInsLname.Name = "txtInsLname";
            txtInsLname.Size = new Size(182, 23);
            txtInsLname.TabIndex = 45;
            // 
            // txtIns_fname
            // 
            txtIns_fname.Location = new Point(400, 127);
            txtIns_fname.Margin = new Padding(3, 2, 3, 2);
            txtIns_fname.Name = "txtIns_fname";
            txtIns_fname.Size = new Size(182, 23);
            txtIns_fname.TabIndex = 44;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.FromArgb(192, 255, 255);
            Address.Location = new Point(184, 186);
            Address.Name = "Address";
            Address.Size = new Size(182, 32);
            Address.TabIndex = 42;
            Address.Text = "Department Id";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.FromArgb(192, 255, 255);
            LastName.Location = new Point(184, 152);
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
            FirstName.Location = new Point(184, 116);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(137, 32);
            FirstName.TabIndex = 40;
            FirstName.Text = "First Name";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 128);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.ForeColor = Color.FromArgb(64, 64, 64);
            back.Location = new Point(322, 324);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(180, 46);
            back.TabIndex = 52;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // InsertInsorm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(txtInsphone);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_insert);
            Controls.Add(txtDeptId);
            Controls.Add(txtInsLname);
            Controls.Add(txtIns_fname);
            Controls.Add(Address);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Name = "InsertInsorm";
            Text = "InsertInsorm";
            Load += InsertInsorm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInsphone;
        private Label label1;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_insert;
        private TextBox txtDeptId;
        private TextBox txtInsLname;
        private TextBox txtIns_fname;
        private Label Address;
        private Label LastName;
        private Label FirstName;
        private Button back;
    }
}