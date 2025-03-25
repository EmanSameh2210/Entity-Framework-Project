namespace EF_Project_Forms
{
    partial class InsertCourseSessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertCourseSessionForm));
            back = new Button();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_insert = new Button();
            InsId = new TextBox();
            title = new TextBox();
            date = new TextBox();
            I = new Label();
            t = new Label();
            FirstName = new Label();
            cId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 128);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(315, 327);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(180, 46);
            back.TabIndex = 61;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(255, 128, 128);
            btn_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_exit.Location = new Point(554, 327);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(180, 46);
            btn_exit.TabIndex = 60;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Row_affected
            // 
            Row_affected.AutoSize = true;
            Row_affected.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            Row_affected.ForeColor = Color.Green;
            Row_affected.Location = new Point(461, 351);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 59;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(128, 255, 128);
            btn_insert.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_insert.Location = new Point(64, 327);
            btn_insert.Margin = new Padding(3, 2, 3, 2);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(180, 46);
            btn_insert.TabIndex = 58;
            btn_insert.Text = "Insert ";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // InsId
            // 
            InsId.Location = new Point(405, 192);
            InsId.Margin = new Padding(3, 2, 3, 2);
            InsId.Name = "InsId";
            InsId.Size = new Size(182, 23);
            InsId.TabIndex = 57;
            // 
            // title
            // 
            title.Location = new Point(405, 158);
            title.Margin = new Padding(3, 2, 3, 2);
            title.Name = "title";
            title.Size = new Size(182, 23);
            title.TabIndex = 56;
            // 
            // date
            // 
            date.Location = new Point(405, 124);
            date.Margin = new Padding(3, 2, 3, 2);
            date.Name = "date";
            date.Size = new Size(182, 23);
            date.TabIndex = 55;
            // 
            // I
            // 
            I.AutoSize = true;
            I.BackColor = Color.Transparent;
            I.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            I.ForeColor = Color.FromArgb(192, 255, 255);
            I.Location = new Point(189, 183);
            I.Name = "I";
            I.Size = new Size(158, 32);
            I.TabIndex = 54;
            I.Text = "Instructor Id";
            // 
            // t
            // 
            t.AutoSize = true;
            t.BackColor = Color.Transparent;
            t.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            t.ForeColor = Color.FromArgb(192, 255, 255);
            t.Location = new Point(189, 149);
            t.Name = "t";
            t.Size = new Size(64, 32);
            t.TabIndex = 53;
            t.Text = "Title";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FirstName.ForeColor = Color.FromArgb(192, 255, 255);
            FirstName.Location = new Point(189, 113);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(67, 32);
            FirstName.TabIndex = 52;
            FirstName.Text = "Date";
            // 
            // cId
            // 
            cId.Location = new Point(405, 231);
            cId.Margin = new Padding(3, 2, 3, 2);
            cId.Name = "cId";
            cId.Size = new Size(182, 23);
            cId.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(189, 222);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 62;
            label1.Text = "Course Id";
            // 
            // InsertCourseSessionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(cId);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_insert);
            Controls.Add(InsId);
            Controls.Add(title);
            Controls.Add(date);
            Controls.Add(I);
            Controls.Add(t);
            Controls.Add(FirstName);
            Name = "InsertCourseSessionForm";
            Text = "InsertCourseSessionForm";
            Load += InsertCourseSessionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_insert;
        private TextBox InsId;
        private TextBox title;
        private TextBox date;
        private Label I;
        private Label t;
        private Label FirstName;
        private TextBox cId;
        private Label label1;
    }
}