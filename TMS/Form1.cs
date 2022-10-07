using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Create SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Global.Database + ";Integrated Security=True;Connect Timeout=30");

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
            Application.Exit();
        }

        //Login Button
        private void rButtons1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Employees where Emp_ID = '" + empIdTB.Text + "' and Emp_Pin = '" + empPinTB.Text + "'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Global.Emp_ID = empIdTB.Text;
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Employee ID or Employee Pin");
                empPinTB.Text = "";
            }
            Con.Close();
        }
    }
}