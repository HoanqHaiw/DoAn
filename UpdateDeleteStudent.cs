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
    public partial class UpdateDeleteStudent : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private void txtExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(267, 97);
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermanent.Clear();
            txtCollage.Clear();
            txtIdproof.Clear(); 
            txtRoomNo.Clear();
            comboxLiving.SelectedIndex = -1;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM newStudent WHERE mobile =" +txtMobile.Text+ "";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermanent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtCollage.Text = ds.Tables[0].Rows[0][7].ToString();
                txtIdproof.Text = ds.Tables[0].Rows[0][8].ToString();
                txtRoomNo.Text = ds.Tables[0].Rows[0][9].ToString();
                comboxLiving.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                clearAll();
                MessageBox.Show("Số điện thoại không tồn tại!","THÔNG TIN",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String name = txtName.Text;
            String fname = txtFather.Text;
            String mname = txtMother.Text;
            String email = txtEmail.Text;
            String paddress = txtPermanent.Text;
            String collage = txtCollage.Text;
            String idproof = txtIdproof.Text;
            Int64 roomNo = Int64.Parse(txtRoomNo.Text);
            String livingStatus = comboxLiving.Text;

            query = " update newStudent set name=  '" +name+ "', fname= '" +fname+ "', mname= '" +mname+"', email= '"+email+"',paddress = '" +paddress+ "', college = '" +collage+ "', idproof = '" +idproof+ "', roomNo = '" +roomNo+ "', living = '" +livingStatus+ "' where mobile = " +mobile+ " update rooms set Booked = '" +livingStatus+ "' where roomNo = " +roomNo+"";
            fn.setData(query,"CẬP NHẬT DỮ LIỆU THÀNH CÔNG ");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("BẠN CÓ CHẮC KHÔNG","XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM newStudent WHERE mobile = " + txtMobile.Text + "";
                fn.setData(query, "ĐÃ XÓA SINH VIÊN");
                clearAll();
            }
        }

        private void comboxLiving_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
