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
using TMS.Contols;

namespace TMS
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            PopEmp();
            PopPerm();
            PopTools();
            String Message = "Employee ID: " + Settings.Emp_ID;
            TB_EMP_ID1.Text = Message;
            TB_EMP_ID2.Text = Message;
            TB_EMP_ID3.Text = Message;
            TB_EMP_ID4.Text = Message;
            TB_EMP_ID5.Text = Message;
            TB_EMP_ID6.Text = Message;
            TB_EMP_ID7.Text = Message;
        }

        //Create SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=" + Settings.Source + ";AttachDbFilename=" + Settings.Database + ";Integrated Security=" + Settings.Security + ";Connect Timeout=" + Settings.Timeout);

        //********UPDATES********

        //Reload Employees List 
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
        //Reload Permissions List 
        void PopPerm()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from Permissions";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                PermGridView.DataSource = ds.Tables[0];
                Con.Close();
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

        //********EMPLOYEES********

        //Add Employee Button
        private void add_User_Click(object sender, EventArgs e)
        {
            try
            {
                //Open SQL and Save User
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employees values('" + empIDAddTB.Text + "','" + EmpPinAddTB.Text + "', '" + empNameAddTB.Text + "','" + empPnumAddTB.Text + "')", Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                //Reloead User List
                UpdatePerms();
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
                Con.Close();
                RemovePermissions();
            }
        }

        //********TOOLS********

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

        //********PERMISSIONS********

        //Update Permissions
        void UpdatePerms()
        {
            try
            {
                //Open SQL and Save User
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Permissions values('" + empIDAddTB.Text + "','" + (COT_Tools_CB.Checked).ToString() + "','" + (CIT_Tools_CB.Checked).ToString() 
                    + "','" + (THS_Tools_CB.Checked).ToString() + "','" + (UHS_Tools_CB.Checked).ToString() + "','" + (TH_Tools_CB.Checked).ToString() + "','" + (UH_Tools_CB.Checked).ToString() 
                    + "','" + (AU_Tools_CB.Checked).ToString() + "','" + (AT_Tools_CB.Checked).ToString() + "','" + (RU_Tools_CB.Checked).ToString() + "','" + (RT_Tools_CB.Checked).ToString() 
                    + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added Successfully");
                Con.Close();
                //Reloead User List
                PopEmp();
                PopPerm();
                ClearEmp();
            }
            catch
            {

            }
        }
        void RemovePermissions()
        {
            //Delete User from SQL
            Con.Open();
            string myquery = "delete from Permissions where Emp_ID='" + empRemove.Text + "'";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee " + empRemove.Text + " successfully removed!");
            Con.Close();
            empRemove.Text = "";
            PopEmp();
            PopPerm();
            ClearEmp();
        }
    }
}
