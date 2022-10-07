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
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PopEmp();
            PopTools();
        }
        
        //Create SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Keith\source\repos\TMS\TMS\Database\TMS.mdf;Integrated Security=True;Connect Timeout=30");

        //Reload User List 
        void PopEmp()
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
                ClearEmp();
            }
            catch
            {

            }
        }

        //Reload Tools List
        void PopTools()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from Tools";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridTools.DataSource = ds.Tables[0];
                Con.Close();
                ClearTool();
            }
            catch
            {

            }
        }

        //Add User Button
        private void add_User_Click(object sender, EventArgs e)
        {
            try
            {
                //Open SQL and Save User
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employees values('" + empIDAddTB.Text + "','" + EmpPinAddTB.Text + "', '" + empNameAddTB.Text + "','" + empPnumAddTB.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employees Successfully Added");
                Con.Close();
                //Reloead User List
                PopEmp();
                ClearEmp();
            }
            catch
            {

            }
        }

        //Remove Employee from Database
        private void rButtons5_Click(object sender, EventArgs e)
        {
            if (empRemove.Text == "")
            {
                MessageBox.Show("Enter Employee ID Number");
            }
            else
            {
                //Delete User from SQL
                Con.Open();
                string myquery = "delete from Employees where Emp_ID='" + empRemove.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee " + empRemove.Text + " successfully removed!");
                Con.Close();
                empRemove.Text = "";
                PopEmp();
                ClearEmp();
            }
        }

        //Add Tool to Database
        private void rButtons4_Click(object sender, EventArgs e)
        {
            try
            {
                //Open SQL and Save User
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tools values('" + toolIDAddTB.Text + "','" + toolTypeAddTB.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tool Successfully Added");
                Con.Close();
                //Reloead User List
                PopTools();
                ClearTool();
            }
            catch
            {

            }
        }

        //Remove Tool from database
        private void rButtons6_Click(object sender, EventArgs e)
        {
            if (toolRemove.Text == "")
            {
                MessageBox.Show("Enter Tool ID Number");
            }
            else
            {
                //Delete User from SQL
                Con.Open();
                string myquery = "delete from Tools where Tool_ID='" + toolRemove.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tool " + toolRemove.Text + " successfully removed!");
                Con.Close();
                toolRemove.Text = "";
                PopTools();
                ClearTool();
            }
        }
    }
}
