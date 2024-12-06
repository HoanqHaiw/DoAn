using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Contract : Form
    {
        function fn = new function();
        String query;
        public Contract()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AllContract ac = new AllContract();
            ac.Show();
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            LoadRoomNumbers();
        }
        private void LoadRoomNumbers()
        {
            string query = "SELECT roomNo FROM rooms WHERE roomStatus = 'YES'";

            // Sử dụng hàm getData để lấy dữ liệu từ SQL
            DataSet dataSet = fn.getData(query);

            // Lấy danh sách số phòng và thêm vào ComboBox
            cbRoomNumbers.Items.Clear();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                cbRoomNumbers.Items.Add(row["roomNo"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalculateRent();
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CalculateRent();
        }
        private void CalculateRent()
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if (endDate > startDate)
            {
                int months = ((endDate.Year - startDate.Year) * 12) + (endDate.Month - startDate.Month);
                if (endDate.Day < startDate.Day) months--;

                long rentAmount = months * 400; // 400 là tiền thuê mỗi tháng
                txtRentAmount.Text = rentAmount.ToString(); // Hiển thị tiền thuê trong TextBox txtRentAmount
            }
            else
            {
                txtRentAmount.Text = "0";
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            try // xét ngoại lệ
            {
                // Thu thập dữ liệu từ form
                int studentId = int.Parse(txtStudentId.Text);
                int roomNo = int.Parse(cbRoomNumbers.SelectedItem.ToString());
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                long rentAmount = long.Parse(txtRentAmount.Text);
                string status = "Active"; // Mặc định trạng thái hợp đồng là Active

                // Truy vấn thêm hợp đồng vào bảng contracts
                string query = "INSERT INTO contracts (studentId, roomNo, startDate, endDate, rentalAmount, status) " +
                               $"VALUES ({studentId}, {roomNo}, '{startDate:yyyy-MM-dd}', '{endDate:yyyy-MM-dd}', {rentAmount}, '{status}')";

                // Gọi hàm setData
                fn.setData(query, "Hợp đồng đã được thêm thành công!");
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
