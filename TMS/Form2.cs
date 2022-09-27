using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Keith\OneDrive\Documents\EmployeesDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void add_User_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employees values('" + empIDAddTB.Text + "','" + EmpPinAddTB.Text + "', '" + empNameAddTB.Text + "','" + empPnumAddTB.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employees Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from Employees";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                EmpGridView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void rButtons5_Click(object sender, EventArgs e)
        {
            if (empRemove.Text == "")
            {
                MessageBox.Show("Enter Employee ID Number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from Employees where Employee_ID='" + empRemove.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee " + empRemove.Text + " successfully removed!");
                Con.Close();
                empRemove.Text = "";
                populate();
            }
        }
    }
}
