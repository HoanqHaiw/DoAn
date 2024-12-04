namespace DoAn
{
    partial class ManageEmployeee
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
            this.btnNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllEmployeeWorking = new Guna.UI2.WinForms.Guna2Button();
            this.btnClean = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(256, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quản Lý Nhân Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.btnNewEmployee.Location = new System.Drawing.Point(30, 107);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(180, 45);
            this.btnNewEmployee.TabIndex = 12;
            this.btnNewEmployee.Text = "Thêm Nhân Viên";
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
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
            this.btnUpdateDeleteEmployee.Location = new System.Drawing.Point(295, 107);
            this.btnUpdateDeleteEmployee.Name = "btnUpdateDeleteEmployee";
            this.btnUpdateDeleteEmployee.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateDeleteEmployee.TabIndex = 13;
            this.btnUpdateDeleteEmployee.Text = "CN-Xóa - NV";
            this.btnUpdateDeleteEmployee.Click += new System.EventHandler(this.btnUpdateDeleteEmployee_Click);
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
            this.btnAllEmployeeWorking.Location = new System.Drawing.Point(546, 107);
            this.btnAllEmployeeWorking.Name = "btnAllEmployeeWorking";
            this.btnAllEmployeeWorking.Size = new System.Drawing.Size(180, 45);
            this.btnAllEmployeeWorking.TabIndex = 14;
            this.btnAllEmployeeWorking.Text = "Tất Cả Nhân Viên";
            this.btnAllEmployeeWorking.Click += new System.EventHandler(this.btnAllEmployeeWorking_Click);
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
            this.btnClean.Location = new System.Drawing.Point(209, 251);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(108, 45);
            this.btnClean.TabIndex = 26;
            this.btnClean.Text = "Đóng";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(473, 251);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(108, 45);
            this.guna2Button1.TabIndex = 27;
            this.guna2Button1.Text = "Thoát";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ManageEmployeee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnAllEmployeeWorking);
            this.Controls.Add(this.btnUpdateDeleteEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployeee";
            this.Text = "ManageEmployeee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnNewEmployee;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteEmployee;
        private Guna.UI2.WinForms.Guna2Button btnAllEmployeeWorking;
        private Guna.UI2.WinForms.Guna2Button btnClean;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}