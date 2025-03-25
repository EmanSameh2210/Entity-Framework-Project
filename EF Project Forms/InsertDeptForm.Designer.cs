namespace EF_Project_Forms
{
    partial class InsertDeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertDeptForm));
            back = new Button();
            btn_exit = new Button();
            Row_affected = new Label();
            btn_insert = new Button();
            last_name = new TextBox();
            first_name = new TextBox();
            deptlocation = new Label();
            deptname = new Label();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 255, 128);
            back.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            back.Location = new Point(316, 285);
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
            btn_exit.Location = new Point(555, 285);
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
            Row_affected.Location = new Point(462, 309);
            Row_affected.Name = "Row_affected";
            Row_affected.Size = new Size(0, 29);
            Row_affected.TabIndex = 59;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(128, 255, 128);
            btn_insert.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            btn_insert.Location = new Point(65, 285);
            btn_insert.Margin = new Padding(3, 2, 3, 2);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(180, 46);
            btn_insert.TabIndex = 58;
            btn_insert.Text = "Insert ";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // last_name
            // 
            last_name.Location = new Point(405, 158);
            last_name.Margin = new Padding(3, 2, 3, 2);
            last_name.Name = "last_name";
            last_name.Size = new Size(182, 23);
            last_name.TabIndex = 56;
            // 
            // first_name
            // 
            first_name.Location = new Point(405, 124);
            first_name.Margin = new Padding(3, 2, 3, 2);
            first_name.Name = "first_name";
            first_name.Size = new Size(182, 23);
            first_name.TabIndex = 55;
            // 
            // deptlocation
            // 
            deptlocation.AutoSize = true;
            deptlocation.BackColor = Color.Transparent;
            deptlocation.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            deptlocation.ForeColor = Color.FromArgb(192, 255, 255);
            deptlocation.Location = new Point(189, 149);
            deptlocation.Name = "deptlocation";
            deptlocation.Size = new Size(119, 32);
            deptlocation.TabIndex = 53;
            deptlocation.Text = " Location";
            // 
            // deptname
            // 
            deptname.AutoSize = true;
            deptname.BackColor = Color.Transparent;
            deptname.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            deptname.ForeColor = Color.FromArgb(192, 255, 255);
            deptname.Location = new Point(189, 113);
            deptname.Name = "deptname";
            deptname.Size = new Size(167, 32);
            deptname.TabIndex = 52;
            deptname.Text = "Depart Name";
            // 
            // InsertDeptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(btn_exit);
            Controls.Add(Row_affected);
            Controls.Add(btn_insert);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(deptlocation);
            Controls.Add(deptname);
            Name = "InsertDeptForm";
            Text = "InsertDeptForm";
            Load += InsertDeptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button btn_exit;
        private Label Row_affected;
        private Button btn_insert;
        private TextBox last_name;
        private TextBox first_name;
        private Label deptlocation;
        private Label deptname;
    }
}