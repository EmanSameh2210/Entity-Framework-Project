namespace EF_Project_Forms
{
    partial class DeleteCourseSessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCourseSessionForm));
            cId = new TextBox();
            label1 = new Label();
            InsId = new TextBox();
            title = new TextBox();
            date = new TextBox();
            I = new Label();
            t = new Label();
            FirstName = new Label();
            CSCombo = new ComboBox();
            back = new Button();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_delete = new Button();
            ID = new Label();
            SuspendLayout();
            // 
            // cId
            // 
            cId.Location = new Point(383, 263);
            cId.Margin = new Padding(3, 2, 3, 2);
            cId.Name = "cId";
            cId.Size = new Size(182, 23);
            cId.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(167, 254);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 86;
            label1.Text = "Course Id";
            // 
            // InsId
            // 
            InsId.Location = new Point(383, 224);
            InsId.Margin = new Padding(3, 2, 3, 2);
            InsId.Name = "InsId";
            InsId.Size = new Size(182, 23);
            InsId.TabIndex = 85;
            // 
            // title
            // 
            title.Location = new Point(383, 190);
            title.Margin = new Padding(3, 2, 3, 2);
            title.Name = "title";
            title.Size = new Size(182, 23);
            title.TabIndex = 84;
            // 
            // date
            // 
            date.Location = new Point(383, 156);
            date.Margin = new Padding(3, 2, 3, 2);
            date.Name = "date";
            date.Size = new Size(182, 23);
            date.TabIndex = 83;
            // 
            // I
            // 
            I.AutoSize = true;
            I.BackColor = Color.Transparent;
            I.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            I.ForeColor = Color.FromArgb(128, 255, 255);
            I.Location = new Point(167, 215);
            I.Name = "I";
            I.Size = new Size(158, 32);
            I.TabIndex = 82;
            I.Text = "Instructor Id";
            // 
            // t
            // 
            t.AutoSize = true;
            t.BackColor = Color.Transparent;
            t.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            t.ForeColor = Color.FromArgb(128, 255, 255);
            t.Location = new Point(167, 181);
            t.Name = "t";
            t.Size = new Size(64, 32);
            t.TabIndex = 81;
            t.Text = "Title";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(128, 255, 255);
            FirstName.Location = new Point(167, 145);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(67, 32);
            FirstName.TabIndex = 80;
            FirstName.Text = "Date";
            // 
            // CSCombo
            // 
            CSCombo.FormattingEnabled = true;
            CSCombo.Location = new Point(429, 89);
            CSCombo.Name = "CSCombo";
            CSCombo.Size = new Size(206, 23);
            CSCombo.TabIndex = 79;
            CSCombo.SelectedIndexChanged += CSCombo_SelectedIndexChanged;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(192, 255, 192);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(317, 322);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(182, 54);
            back.TabIndex = 78;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 128, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(549, 322);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(182, 54);
            btn_exit.TabIndex = 77;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Green;
            Row_affected.Location = new Point(476, 338);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 76;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 128, 255);
            btn_delete.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_delete.Location = new Point(70, 322);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(182, 54);
            btn_delete.TabIndex = 75;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.Transparent;
            ID.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.ForeColor = Color.FromArgb(0, 64, 64);
            ID.Location = new Point(167, 75);
            ID.Name = "ID";
            ID.Size = new Size(240, 37);
            ID.TabIndex = 74;
            ID.Text = "Course Session Id";
            // 
            // DeleteCourseSessionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(cId);
            Controls.Add(label1);
            Controls.Add(InsId);
            Controls.Add(title);
            Controls.Add(date);
            Controls.Add(I);
            Controls.Add(t);
            Controls.Add(FirstName);
            Controls.Add(CSCombo);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_delete);
            Controls.Add(ID);
            Name = "DeleteCourseSessionForm";
            Text = "DeleteCourseSessionForm";
            Load += DeleteCourseSessionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cId;
        private Label label1;
        private TextBox InsId;
        private TextBox title;
        private TextBox date;
        private Label I;
        private Label t;
        private Label FirstName;
        private ComboBox CSCombo;
        private Button back;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_delete;
        private Label ID;
    }
}