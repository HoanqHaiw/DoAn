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
    public partial class NewEmployee : Form
    {
        function fn = new function();
        String query;
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(267, 97);
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmailId.Clear();
            txtPernament.Clear();
            txtUniqueId.Clear();
            txtDesignation.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text !="" && txtName.Text!= "" && txtFather.Text != "" && txtMother.Text != "" && txtEmailId.Text != "" && txtPernament.Text != "" && txtUniqueId.Text != "" &&txtDesignation.SelectedIndex != -1)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmailId.Text;
                String address = txtPernament.Text;
                String id= txtUniqueId.Text;
                String designation = txtDesignation.Text;

                query = "insert into newEmployee(emobile,ename,efname,emname,eemail,epaddress,eidproof,edesignation) values (" + mobile + ",'" + name + "', '" + fname + "', '" + mname + "','" + email + "', '" + address + "', '" + id + "','" +designation+ "')";
                fn.setData(query, "Đã Thêm Nhân Viên");
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
