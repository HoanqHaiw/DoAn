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
            this.btnExist = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllEmployeeWorking = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployeePayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllStudentLiving = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentFees = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageRooms = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(475, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản Lý Kí Túc Xá";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.btnExist.Location = new System.Drawing.Point(1062, 9);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(93, 36);
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
            this.btnLogOut.Location = new System.Drawing.Point(882, 44);
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
            this.btnLeavedEmployee.Location = new System.Drawing.Point(39, 607);
            this.btnLeavedEmployee.Name = "btnLeavedEmployee";
            this.btnLeavedEmployee.Size = new System.Drawing.Size(180, 45);
            this.btnLeavedEmployee.TabIndex = 13;
            this.btnLeavedEmployee.Text = "NV Thôi Việc";
            // 
            // btnAllEmployeeWorking
            // 
            this.btnAllEmployeeWorking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllEmployeeWorking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllEmployeeWorking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllEmployeeWorking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllEmployeeWorking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllEmployeeWorking.FillColor = System.Drawing.Color.Transparent;
            this.btnAllEmployeeWorking.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllEmployeeWorking.ForeColor = System.Drawing.Color.Black;
            this.btnAllEmployeeWorking.Image = global::DoAn.Properties.Resources.new_student;
            this.btnAllEmployeeWorking.Location = new System.Drawing.Point(39, 556);
            this.btnAllEmployeeWorking.Name = "btnAllEmployeeWorking";
            this.btnAllEmployeeWorking.Size = new System.Drawing.Size(180, 45);
            this.btnAllEmployeeWorking.TabIndex = 12;
            this.btnAllEmployeeWorking.Text = "Tất Cả Nhân Viên";
            // 
            // btnEmployeePayment
            // 
            this.btnEmployeePayment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployeePayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeePayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployeePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployeePayment.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployeePayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeePayment.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeePayment.Image = global::DoAn.Properties.Resources.Fees1;
            this.btnEmployeePayment.Location = new System.Drawing.Point(39, 505);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.Size = new System.Drawing.Size(180, 45);
            this.btnEmployeePayment.TabIndex = 11;
            this.btnEmployeePayment.Text = "Thanh Toán Lương";
            // 
            // btnUpdateDeleteEmployee
            // 
            this.btnUpdateDeleteEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDeleteEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDeleteEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDeleteEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDeleteEmployee.Image = global::DoAn.Properties.Resources.delete2;
            this.btnUpdateDeleteEmployee.Location = new System.Drawing.Point(39, 454);
            this.btnUpdateDeleteEmployee.Name = "btnUpdateDeleteEmployee";
            this.btnUpdateDeleteEmployee.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateDeleteEmployee.TabIndex = 10;
            this.btnUpdateDeleteEmployee.Text = "CN-Xóa - NV";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnNewEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnNewEmployee.Image = global::DoAn.Properties.Resources.Update___Delete_Student3;
            this.btnNewEmployee.Location = new System.Drawing.Point(39, 403);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(180, 45);
            this.btnNewEmployee.TabIndex = 9;
            this.btnNewEmployee.Text = "Thêm Nhân Viên";
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
            this.btnLeavedStudent.Location = new System.Drawing.Point(39, 352);
            this.btnLeavedStudent.Name = "btnLeavedStudent";
            this.btnLeavedStudent.Size = new System.Drawing.Size(180, 45);
            this.btnLeavedStudent.TabIndex = 8;
            this.btnLeavedStudent.Text = "SV Trả Phòng";
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
            this.btnAllStudentLiving.Location = new System.Drawing.Point(39, 301);
            this.btnAllStudentLiving.Name = "btnAllStudentLiving";
            this.btnAllStudentLiving.Size = new System.Drawing.Size(180, 45);
            this.btnAllStudentLiving.TabIndex = 7;
            this.btnAllStudentLiving.Text = "Trạng Thái";
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
            this.btnStudentFees.Location = new System.Drawing.Point(39, 250);
            this.btnStudentFees.Name = "btnStudentFees";
            this.btnStudentFees.Size = new System.Drawing.Size(180, 45);
            this.btnStudentFees.TabIndex = 6;
            this.btnStudentFees.Text = "Thanh Toán Phòng";
            this.btnStudentFees.Click += new System.EventHandler(this.btnStudentFees_Click);
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
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(39, 199);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateDeleteStudent.TabIndex = 5;
            this.btnUpdateDeleteStudent.Text = "CP-Xóa-SV";
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
            this.btnNewStudent.Location = new System.Drawing.Point(39, 148);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(180, 45);
            this.btnNewStudent.TabIndex = 4;
            this.btnNewStudent.Text = "Thêm Sinh Viên";
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
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
            this.btnManageRooms.Location = new System.Drawing.Point(39, 97);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(180, 45);
            this.btnManageRooms.TabIndex = 3;
            this.btnManageRooms.Text = "Quản Lý Phòng";
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::DoAn.Properties.Resources.IMG_0384;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(267, 97);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(843, 565);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1158, 674);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLeavedEmployee);
            this.Controls.Add(this.btnAllEmployeeWorking);
            this.Controls.Add(this.btnEmployeePayment);
            this.Controls.Add(this.btnUpdateDeleteEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.btnLeavedStudent);
            this.Controls.Add(this.btnAllStudentLiving);
            this.Controls.Add(this.btnStudentFees);
            this.Controls.Add(this.btnUpdateDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
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
        private Guna.UI2.WinForms.Guna2Button btnNewStudent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteStudent;
        private Guna.UI2.WinForms.Guna2Button btnStudentFees;
        private Guna.UI2.WinForms.Guna2Button btnAllStudentLiving;
        private Guna.UI2.WinForms.Guna2Button btnLeavedStudent;
        private Guna.UI2.WinForms.Guna2Button btnNewEmployee;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteEmployee;
        private Guna.UI2.WinForms.Guna2Button btnEmployeePayment;
        private Guna.UI2.WinForms.Guna2Button btnAllEmployeeWorking;
        private Guna.UI2.WinForms.Guna2Button btnLeavedEmployee;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnExist;
    }
}