namespace DoAn
{
    partial class manageStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnClean = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllStudentLiving = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quản Lý Sinh Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::DoAn.Properties.Resources.clear;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(563, 333);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(108, 45);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Thoát";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnClean
            // 
            this.btnClean.BorderRadius = 15;
            this.btnClean.BorderThickness = 1;
            this.btnClean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClean.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClean.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.Black;
            this.btnClean.Image = global::DoAn.Properties.Resources.clear;
            this.btnClean.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClean.Location = new System.Drawing.Point(289, 333);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(108, 45);
            this.btnClean.TabIndex = 25;
            this.btnClean.Text = "Đóng";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAllStudentLiving
            // 
            this.btnAllStudentLiving.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllStudentLiving.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllStudentLiving.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllStudentLiving.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllStudentLiving.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllStudentLiving.FillColor = System.Drawing.Color.Transparent;
            this.btnAllStudentLiving.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudentLiving.ForeColor = System.Drawing.Color.Black;
            this.btnAllStudentLiving.Image = global::DoAn.Properties.Resources.room;
            this.btnAllStudentLiving.Location = new System.Drawing.Point(766, 120);
            this.btnAllStudentLiving.Name = "btnAllStudentLiving";
            this.btnAllStudentLiving.Size = new System.Drawing.Size(180, 45);
            this.btnAllStudentLiving.TabIndex = 11;
            this.btnAllStudentLiving.Text = "Trạng Thái";
            this.btnAllStudentLiving.Click += new System.EventHandler(this.btnAllStudentLiving_Click);
            // 
            // btnLeavedStudent
            // 
            this.btnLeavedStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavedStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavedStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavedStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnLeavedStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavedStudent.ForeColor = System.Drawing.Color.Black;
            this.btnLeavedStudent.Image = global::DoAn.Properties.Resources.home;
            this.btnLeavedStudent.Location = new System.Drawing.Point(511, 120);
            this.btnLeavedStudent.Name = "btnLeavedStudent";
            this.btnLeavedStudent.Size = new System.Drawing.Size(180, 45);
            this.btnLeavedStudent.TabIndex = 9;
            this.btnLeavedStudent.Text = "SV Trả Phòng";
            this.btnLeavedStudent.Click += new System.EventHandler(this.btnLeavedStudent_Click);
            // 
            // btnUpdateDeleteStudent
            // 
            this.btnUpdateDeleteStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDeleteStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDeleteStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDeleteStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteStudent.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDeleteStudent.Image = global::DoAn.Properties.Resources.Update___Delete_Student2;
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(264, 120);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateDeleteStudent.TabIndex = 6;
            this.btnUpdateDeleteStudent.Text = "CN-Xóa-SV";
            this.btnUpdateDeleteStudent.Click += new System.EventHandler(this.btnUpdateDeleteStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnNewStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudent.ForeColor = System.Drawing.Color.Black;
            this.btnNewStudent.Image = global::DoAn.Properties.Resources.all_student_living;
            this.btnNewStudent.Location = new System.Drawing.Point(26, 120);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(180, 45);
            this.btnNewStudent.TabIndex = 5;
            this.btnNewStudent.Text = "Thêm Sinh Viên";
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // manageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 604);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnAllStudentLiving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLeavedStudent);
            this.Controls.Add(this.btnUpdateDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageStudent";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.manageStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnNewStudent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteStudent;
        private Guna.UI2.WinForms.Guna2Button btnLeavedStudent;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnAllStudentLiving;
        private Guna.UI2.WinForms.Guna2Button btnClean;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}