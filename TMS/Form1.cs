using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Hide or Show Password.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                empPinTB.PasswordChar = false;
            else
                empPinTB.PasswordChar = true;
        }

        //Clear EmpID and Password Form
        private void label4_Click(object sender, EventArgs e)
        {
            empIdTB.Text = "";
            empPinTB.Text = "";
        }

        //Close Button
        private void rButtons2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}