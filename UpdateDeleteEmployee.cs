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
    }
}
