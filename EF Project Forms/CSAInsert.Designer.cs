namespace EF_Project_Forms
{
    partial class CSAInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSAInsert));
            back = new Button();
            csid = new TextBox();
            label1 = new Label();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_insert = new Button();
            sid = new TextBox();
            notes = new TextBox();
            grade = new TextBox();
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
            // 
            // csid
            // 
            csid.Location = new Point(415, 211);
            csid.Margin = new Padding(3, 2, 3, 2);
            csid.Name = "csid";
            csid.Size = new Size(182, 23);
            csid.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(172, 202);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 49;
            label1.Text = "Course Session Id";
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
            // sid
            // 
            sid.Location = new Point(415, 177);
            sid.Margin = new Padding(3, 2, 3, 2);
            sid.Name = "sid";
            sid.Size = new Size(182, 23);
            sid.TabIndex = 45;
            // 
            // notes
            // 
            notes.Location = new Point(415, 143);
            notes.Margin = new Padding(3, 2, 3, 2);
            notes.Name = "notes";
            notes.Size = new Size(182, 23);
            notes.TabIndex = 44;
            // 
            // grade
            // 
            grade.Location = new Point(415, 109);
            grade.Margin = new Padding(3, 2, 3, 2);
            grade.Name = "grade";
            grade.Size = new Size(182, 23);
            grade.TabIndex = 43;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Address.ForeColor = Color.FromArgb(192, 255, 255);
            Address.Location = new Point(172, 168);
            Address.Name = "Address";
            Address.Size = new Size(132, 32);
            Address.TabIndex = 42;
            Address.Text = "Student Id";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LastName.ForeColor = Color.FromArgb(192, 255, 255);
            LastName.Location = new Point(172, 134);
            LastName.Name = "LastName";
            LastName.Size = new Size(81, 32);
            LastName.TabIndex = 41;
            LastName.Text = "Notes";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(192, 255, 255);
            FirstName.Location = new Point(172, 98);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(82, 32);
            FirstName.TabIndex = 40;
            FirstName.Text = "Grade";
            // 
            // CSAInsert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(csid);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_insert);
            Controls.Add(sid);
            Controls.Add(notes);
            Controls.Add(grade);
            Controls.Add(Address);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Name = "CSAInsert";
            Text = "CSAInsert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private TextBox csid;
        private Label label1;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_insert;
        private TextBox sid;
        private TextBox notes;
        private TextBox grade;
        private Label Address;
        private Label LastName;
        private Label FirstName;
    }
}