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
    public partial class NewStudent : Form
    {
        function fn = new function();
        String query;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(267, 97);
            query = "SELECT roomNo from rooms WHERE roomStatus = 'YES' AND Booked = 'NO' "; // select ra số phòng từ bảng rooms và chỉ lấy phòng thỏa mãn 2 điều kiện yes và no
            DataSet ds = fn.getData(query);
            for(int i = 0;i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAll() // xóa bỏ các ô khi đã thêm sinh viên thành công
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermanent.Clear();
            txtCollege.Clear();
            txtIdProof.Clear();
            comboRoomNo.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text != "" && txtName.Text != "" &&txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" &&txtPermanent.Text !=  "" && txtCollege.Text != "" && txtIdProof.Text !="" && comboRoomNo.SelectedIndex != -1)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmail.Text;
                String paddress = txtPermanent.Text;
                String colege = txtCollege.Text;
                String idproof = txtIdProof.Text;
                Int64 roomNo = Int64.Parse(comboRoomNo.Text);


                query = "insert into newStudent(mobile, name, fname, mname, email, paddress, college, idproof, roomNo) values (" + mobile + ",'" +name+ "', '" + fname + "','" +mname + "','" +email +"','" +paddress+ "','" +colege+ "','" +idproof+ "', " +roomNo+ ") update rooms set Booked = 'CO' where roomNo = " +roomNo+""; // thêm vào từng trường mà mình vừa khai báo ở trên và update lại cái trạng thái phòng
                fn.setData(query,"Sinh Viên Đăng Kí Thành Công");
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin","Thông Tin",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
