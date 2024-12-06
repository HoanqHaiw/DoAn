using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class ControlError : Form
    {
        function fn = new function();
        String query;
        public ControlError()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlError_Load(object sender, EventArgs e)
        {
            this.Location = new Point(267, 97);
            dataTimePicker.Format = DateTimePickerFormat.Custom;
            dataTimePicker.CustomFormat = "MMMM yyyy";

            loadRoomNumbers();
        }
        private void loadRoomNumbers()
        {
            query = "SELECT DISTINCT roomNo FROM rooms"; // Truy vấn danh sách phòng
            DataSet ds = fn.getData(query);

            cbrooms.Items.Clear(); // Xóa các mục cũ
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cbrooms.Items.Add(row["roomNo"].ToString());
            }
        }
        public void setDataGrid(Int64 roomNo)
        {
            query = "SELECT issueId, roomNo, description, reportDate, status, employeeInCharge " +
                    "FROM issues WHERE roomNo = " + roomNo+" ";
            DataSet ds = fn.getData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                guna2DataGridView1.DataSource = null; // Không có dữ liệu thì hiển thị rỗng
                MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtErrorId.Clear();
            cbrooms.SelectedIndex = -1; // Đặt về trạng thái chưa chọn
            txtDescription.Clear();
            ComboBoxStatus.SelectedIndex = -1;
            txtEmployeeWork.Clear();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 errorId = Int64.Parse(txtErrorId.Text.Trim());
                Int64 roomNo = Int64.Parse(cbrooms.SelectedItem.ToString()); // Lấy số phòng từ cbrooms
                string description = txtDescription.Text.Trim();
                DateTime reportDate = dataTimePicker.Value;
                string status = ComboBoxStatus.Text.Trim();
                string employeeWork = txtEmployeeWork.Text.Trim();

                query = "UPDATE issues SET roomNo = '" + roomNo +
                        "', description = '" + description +
                        "', reportDate = '" + reportDate.ToString("yyyy-MM-dd") +
                        "', status = '" + status +
                        "', employeeInCharge = '" + employeeWork +
                        "' WHERE issueId = " + errorId+"";

                fn.setData(query, "CẬP NHẬT DỮ LIỆU THÀNH CÔNG");

                setDataGrid(roomNo); // Cập nhật lại DataGridView
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbrooms.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    ComboBoxStatus.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtEmployeeWork.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                long roomNo = long.Parse(cbrooms.SelectedItem.ToString()); // Lấy số phòng từ cbrooms
                string description = txtDescription.Text;
                DateTime reportDate = dataTimePicker.Value;
                string status = ComboBoxStatus.Text;
                string employeeWork = txtEmployeeWork.Text;

                query = $"INSERT INTO issues (roomNo, description, reportDate, status, employeeInCharge) " +
                        $"VALUES ({roomNo}, '{description}', '{reportDate:yyyy-MM-dd}', '{status}', '{employeeWork}')";

                fn.setData(query, "THÊM SỰ CỐ THÀNH CÔNG");



                setDataGrid(roomNo); // Cập nhật DataGridView
                clearAll();

            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho các trường yêu cầu!", "Lỗi Định Dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AllError ae = new AllError();
            ae.Show();
        }
    }
}
    

