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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExist_Click(object sender, EventArgs e)
        {   
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form fn = new Form1();
            fn.Show();
            this.Close();

        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoom arr = new AddNewRoom();
            arr.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
           // NewStudent nst = new NewStudent();
            //nst.Show();
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            StudentFees snf = new StudentFees();
            snf.Show();
        }

        private void btnAllStudentLiving_Click(object sender, EventArgs e)
        {
            AllStudentLiving asl = new AllStudentLiving();
            asl.Show();
        }

        private void btnLeavedStudent_Click(object sender, EventArgs e)
        {
            LeavedStudent lsn = new LeavedStudent();
            lsn.Show();
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

        private void btnLeavedEmployee_Click(object sender, EventArgs e)
        {
            ControlError ce = new ControlError();
            ce.Show();
        }

        private void btnAllEmployeeWorking_Click(object sender, EventArgs e)
        {
            AllEmployeeWorking asl = new AllEmployeeWorking();
            asl.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            manageStudent mst = new manageStudent();
            mst.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            ManageEmployeee me = new ManageEmployeee();
            me.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Contract ct = new Contract();
            ct.Show();
        }
    }
}
