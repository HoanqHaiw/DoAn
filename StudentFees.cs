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
    public partial class StudentFees : Form
    {
        function fn = new function();
        String query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(267, 97);
            dataTimePicker.Format = DateTimePickerFormat.Custom;
            dataTimePicker.CustomFormat = "MMMM yyyy";
        }
        public void setDataGrib(Int64 mobile)
        {
            query = "SELECT * FROM fees WHERE mobileNo = " + mobile + "";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtAmount.Clear();
            txtRoomNo.Clear ();
            txtEmailId.Clear();
            guna2DataGridView1.DataSource = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text !="")
            {
                query = "SELECT name,email,roomNo from newStudent WHERE mobile =" + txtMobile.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmailId.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrib(Int64.Parse(txtMobile.Text));
                    
                }
                else
                {
                    MessageBox.Show("HỒ SƠ KHÔNG TỒN TẠI","Thông Tin",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtAmount.Text !="")
            {
                query = "SELECT * FROM fees WHERE mobileNo = " + Int64.Parse(txtMobile.Text) + "and fmonth= '" + dataTimePicker.Text + "'";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = dataTimePicker.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);
                    query = "insert into fees values (" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query, "Phí đã trả");
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Không có lệ phí của " +dataTimePicker.Text+ "Còn Lại.","Thông Tin",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();

        }
    }
}
