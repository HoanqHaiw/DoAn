namespace DoAn
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageStudents = new Guna.UI2.WinForms.Guna2Button();
            this.btnExist = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentFees = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageRooms = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(473, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản Lý Kí Túc Xá";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageStudents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStudents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStudents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageStudents.FillColor = System.Drawing.Color.Transparent;
            this.btnManageStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudents.ForeColor = System.Drawing.Color.Black;
            this.btnManageStudents.Image = global::DoAn.Properties.Resources.new_student;
            this.btnManageStudents.Location = new System.Drawing.Point(-7, 194);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(222, 45);
            this.btnManageStudents.TabIndex = 16;
            this.btnManageStudents.Text = "Quản Lý Sinh Viên";
            this.btnManageStudents.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnExist
            // 
            this.btnExist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExist.FillColor = System.Drawing.Color.Transparent;
            this.btnExist.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnExist.ForeColor = System.Drawing.Color.Black;
            this.btnExist.Image = global::DoAn.Properties.Resources.x;
            this.btnExist.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExist.Location = new System.Drawing.Point(1091, 0);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(67, 36);
            this.btnExist.TabIndex = 15;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::DoAn.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(939, 6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(155, 30);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLeavedEmployee
            // 
            this.btnLeavedEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavedEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavedEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavedEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnLeavedEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavedEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnLeavedEmployee.Image = global::DoAn.Properties.Resources.logout1;
            this.btnLeavedEmployee.Location = new System.Drawing.Point(-7, 617);
            this.btnLeavedEmployee.Name = "btnLeavedEmployee";
            this.btnLeavedEmployee.Size = new System.Drawing.Size(180, 45);
            this.btnLeavedEmployee.TabIndex = 13;
            this.btnLeavedEmployee.Text = "Quản Lý Sự Cố";
            this.btnLeavedEmployee.Click += new System.EventHandler(this.btnLeavedEmployee_Click);
            // 
            // btnStudentFees
            // 
            this.btnStudentFees.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentFees.FillColor = System.Drawing.Color.Transparent;
            this.btnStudentFees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentFees.ForeColor = System.Drawing.Color.Black;
            this.btnStudentFees.Image = global::DoAn.Properties.Resources.Fees;
            this.btnStudentFees.Location = new System.Drawing.Point(12, 301);
            this.btnStudentFees.Name = "btnStudentFees";
            this.btnStudentFees.Size = new System.Drawing.Size(180, 45);
            this.btnStudentFees.TabIndex = 6;
            this.btnStudentFees.Text = "Quản Lý Hóa Đơn";
            this.btnStudentFees.Click += new System.EventHandler(this.btnStudentFees_Click);
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageRooms.FillColor = System.Drawing.Color.Transparent;
            this.btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRooms.ForeColor = System.Drawing.Color.Black;
            this.btnManageRooms.Image = global::DoAn.Properties.Resources.home;
            this.btnManageRooms.Location = new System.Drawing.Point(12, 97);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(180, 45);
            this.btnManageRooms.TabIndex = 3;
            this.btnManageRooms.Text = "Quản Lý Phòng";
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::DoAn.Properties.Resources._21;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(267, 97);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(843, 565);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::DoAn.Properties.Resources.new_student;
            this.guna2Button1.Location = new System.Drawing.Point(-7, 395);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(221, 45);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "Quản Lý Nhân Viên";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::DoAn.Properties.Resources.save;
            this.guna2Button2.Location = new System.Drawing.Point(12, 522);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Text = "Quản Lý Hợp Đồng";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1158, 674);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLeavedEmployee);
            this.Controls.Add(this.btnStudentFees);
            this.Controls.Add(this.btnManageRooms);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnManageRooms;
        private Guna.UI2.WinForms.Guna2Button btnStudentFees;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnExist;
        private Guna.UI2.WinForms.Guna2Button btnLeavedEmployee;
        private Guna.UI2.WinForms.Guna2Button btnManageStudents;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}