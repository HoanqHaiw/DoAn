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
    public partial class ManageEmployeee : Form
    {
        public ManageEmployeee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee ne = new NewEmployee();
            ne.Show();
        }

        private void btnUpdateDeleteEmployee_Click(object sender, EventArgs e)
        {
            UpdateDeleteEmployee ude = new UpdateDeleteEmployee();
            ude.Show();
        }

        private void btnAllEmployeeWorking_Click(object sender, EventArgs e)
        {
            AllEmployeeWorking asl = new AllEmployeeWorking();
            asl.Show();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
