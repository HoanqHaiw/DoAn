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
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(267, 97);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = " SELECT * FROM newEmployee WHERE emobile = " +txtMobile.Text+"";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count !=0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmailId.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermanent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtUniqueID.Text = ds.Tables[0].Rows[0][7].ToString();
                txtDesignation.Text = ds.Tables[0].Rows[0][8].ToString();
                txtWorking.Text = ds.Tables[0].Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("Ho So Khong Ton Tai ", "Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String name = txtName.Text;
            String fname = txtFather.Text;
            String mname = txtMother.Text;
            String email = txtEmailId.Text;
            String paddress = txtPermanent.Text;
            String id = txtUniqueID.Text;
            String designation = txtDesignation.Text;
            String working = txtWorking.Text;

            query = "Update newEmployee set ename = '" + name + "', efname = '" + fname + "', emname = '" + mname + "', eemail = '" + email + "', epaddress = '" + paddress + "', eidproof = '" + id + "', edesignation = '" + designation + "', working = '" + working + "' where emobile = " + mobile + "";
            fn.setData(query, "Cap Nhat Thanh Cong");

        }
        private void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmailId.Clear();
            txtUniqueID.Clear();
            txtPermanent.Clear();
            txtDesignation.SelectedIndex = -1;
            txtWorking.SelectedIndex = -1;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban Co Chac Khong","Xac Nhan",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                query = "DELETE FROM newEmployee WHERE emobile =" +txtMobile.Text+"";
                fn.setData(query,"Da Xoa Nhan Vien");
                clearAll();
            }
        }
    }
}
