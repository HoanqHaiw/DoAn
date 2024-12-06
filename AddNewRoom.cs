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
    public partial class AddNewRoom : Form
    {
        function fn = new function();
        String query;
        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(267, 97);
            labelRoom.Visible = false;
            labelRoomExist.Visible = false;
            query = "SELECT * FROM rooms ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms WHERE roomNo=" + txtRoomNo1.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                String status;
                if (checkBox1.Checked)
                {
                    status = "YES";

                }
                else
                {
                    status = "NO";
                }
                labelRoomExist.Visible = false;
                query = "insert into rooms (roomNo, roomStatus) values(" + txtRoomNo1.Text + ",'" +status + "') ";
                fn.setData(query, "DA THEM PHONG ");
                AddNewRoom_Load(this,null);
            }
            else
            {
                labelRoomExist.Text = "PHONG DA CO CHU";
                labelRoomExist.Visible=true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms WHERE roomNo = " + txtRoomNo2.Text + "";
            DataSet ds =fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                labelRoom.Text = "PHONG NAY KHONG TON TAI";
                labelRoom.Visible=true;
                checkBox2.Checked = false;
                
            }
            else
            {
                labelRoom.Text = "PHONG NAY DA TIM THAY";
                labelRoom.Visible = true;

                if (ds.Tables[0].Rows[0][1].ToString() == "YES") // vào bảng của data base chuyển thành chuỗi rồi kiểm tra
                {
                    checkBox2.Checked=true;
                }
                else
                {
                    checkBox2.Checked=false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String status;
            if (checkBox2.Checked)
            {
                status = "YES";
            }
            else
            {
                status = "NO";
            }
            query =  " update rooms set roomStatus = '" + status + "' where roomNo = " +txtRoomNo2.Text + "";
            fn.setData(query,"CẬP NHẬT THÀNH CÔNG!");
            AddNewRoom_Load(this, null); //load lại dữ liệu

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(labelRoom.Text== "PHONG NAY DA TIM THAY")
            {
                query = "delete from rooms where roomNo=" + txtRoomNo2.Text + "";
                fn.setData(query,"đã xóa chi tiết phòng");
                AddNewRoom_Load(this, null); //load lại dữ liệu

            }
            else
            {
                MessageBox.Show("THử XÓA LẠI KHÔNG THẤY PHÒNG","LỖI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
