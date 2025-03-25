namespace EF_Project_Forms
{
    partial class CSADelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSADelete));
            csId = new TextBox();
            label1 = new Label();
            sid = new TextBox();
            note = new TextBox();
            grade = new TextBox();
            I = new Label();
            t = new Label();
            FirstName = new Label();
            CSACombo = new ComboBox();
            back = new Button();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_delete = new Button();
            ID = new Label();
            SuspendLayout();
            // 
            // csId
            // 
            csId.Location = new Point(388, 263);
            csId.Margin = new Padding(3, 2, 3, 2);
            csId.Name = "csId";
            csId.Size = new Size(182, 23);
            csId.TabIndex = 101;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(148, 254);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 100;
            label1.Text = "Course Session Id";
            // 
            // sid
            // 
            sid.Location = new Point(388, 224);
            sid.Margin = new Padding(3, 2, 3, 2);
            sid.Name = "sid";
            sid.Size = new Size(182, 23);
            sid.TabIndex = 99;
            // 
            // note
            // 
            note.Location = new Point(388, 190);
            note.Margin = new Padding(3, 2, 3, 2);
            note.Name = "note";
            note.Size = new Size(182, 23);
            note.TabIndex = 98;
            // 
            // grade
            // 
            grade.Location = new Point(388, 156);
            grade.Margin = new Padding(3, 2, 3, 2);
            grade.Name = "grade";
            grade.Size = new Size(182, 23);
            grade.TabIndex = 97;
            // 
            // I
            // 
            I.AutoSize = true;
            I.BackColor = Color.Transparent;
            I.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            I.ForeColor = Color.FromArgb(128, 255, 255);
            I.Location = new Point(148, 215);
            I.Name = "I";
            I.Size = new Size(132, 32);
            I.TabIndex = 96;
            I.Text = "Student Id";
            // 
            // t
            // 
            t.AutoSize = true;
            t.BackColor = Color.Transparent;
            t.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            t.ForeColor = Color.FromArgb(128, 255, 255);
            t.Location = new Point(148, 181);
            t.Name = "t";
            t.Size = new Size(70, 32);
            t.TabIndex = 95;
            t.Text = "Note";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(128, 255, 255);
            FirstName.Location = new Point(148, 145);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(82, 32);
            FirstName.TabIndex = 94;
            FirstName.Text = "Grade";
            // 
            // CSACombo
            // 
            CSACombo.FormattingEnabled = true;
            CSACombo.Location = new Point(464, 89);
            CSACombo.Name = "CSACombo";
            CSACombo.Size = new Size(206, 23);
            CSACombo.TabIndex = 93;
            CSACombo.SelectedIndexChanged += CSACombo_SelectedIndexChanged;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(322, 322);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 54);
            back.TabIndex = 92;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 128, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(554, 322);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(182, 54);
            btn_exit.TabIndex = 91;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Green;
            Row_affected.Location = new Point(481, 338);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 90;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 128, 255);
            btn_delete.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_delete.Location = new Point(75, 322);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(182, 54);
            btn_delete.TabIndex = 89;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_update_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.Transparent;
            ID.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.ForeColor = Color.FromArgb(0, 64, 64);
            ID.Location = new Point(64, 75);
            ID.Name = "ID";
            ID.Size = new Size(394, 37);
            ID.TabIndex = 88;
            ID.Text = "Course Session Attendance Id";
            // 
            // CSADelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(csId);
            Controls.Add(label1);
            Controls.Add(sid);
            Controls.Add(note);
            Controls.Add(grade);
            Controls.Add(I);
            Controls.Add(t);
            Controls.Add(FirstName);
            Controls.Add(CSACombo);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_delete);
            Controls.Add(ID);
            Name = "CSADelete";
            Text = "Delete";
            Load += CSADelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox csId;
        private Label label1;
        private TextBox sid;
        private TextBox note;
        private TextBox grade;
        private Label I;
        private Label t;
        private Label FirstName;
        private ComboBox CSACombo;
        private Button back;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_delete;
        private Label ID;
    }
}