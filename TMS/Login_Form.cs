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
using TMS.Contols;

namespace TMS
{
    public class Permissions
    {
        public string Check_Out { get; set; }
        public string Check_In { get; set; }
        public string Self_His_Tool { get; set; }
        public string Self_His_User { get; set; }
        public string Tool_His { get; set; }
        public string User_His { get; set; }
        public string Add_Users { get; set; }
        public string Add_Tools { get; set; }
        public string Remove_Users { get; set; }
        public string Remove_Tools { get; set; }
    }
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        //Create SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=" + Settings.Source + ";AttachDbFilename=" 
            + Settings.Database + ";Integrated Security=" + Settings.Security + ";Connect Timeout=" 
            + Settings.Timeout);

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
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Employees where Emp_ID = '" + empIdTB.Text + "' and Emp_Pin = '" + empPinTB.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Settings.Verify_Login == true)
            {
                if (dt.Rows[0][0].ToString() == "1")
                    Login();
                else
                {
                    Con.Close();
                    MessageBox.Show("Wrong Employee ID or Employee Pin");
                    empPinTB.Text = "";
                }
            }
            else
            {
                Con.Close();
                Login();
            }
        }
        void Login()
        {
            Settings.Emp_ID = int.Parse(empIdTB.Text);
            Main_Form form2 = new Main_Form();
            Con.Close();
            verify();
            form2.Show();
            this.Hide();
        }

        Permissions Data;
        Permissions verify()
        {
            string SQL = "SELECT * FROM Permissions WHERE Emp_ID = @Emp_ID";

            using var con = new SqlConnection(@"Data Source=" + Settings.Source + ";AttachDbFilename="
            + Settings.Database + ";Integrated Security=" + Settings.Security + ";Connect Timeout="
            + Settings.Timeout);
            using var cmd = new SqlCommand(SQL, con);

            cmd.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = Settings.Emp_ID;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            Permissions result;

            if (rdr.Read())
            {
                result = new Permissions();
                int Emp_ID = Settings.Emp_ID;
                result.Check_Out = (string)rdr["Check_Out"];
                result.Check_In = (string)rdr["Check_In"];
                result.Self_His_Tool = (string)rdr["Self_His_Tool"];
                result.Self_His_User = (string)rdr["Self_His_User"];
                result.Tool_His = (string)rdr["Tool_His"];
                result.User_His = (string)rdr["User_His"];
                result.Add_Users = (string)rdr["Add_Users"];
                result.Add_Tools = (string)rdr["Add_Tools"];
                result.Remove_Users = (string)rdr["Remove_Users"];
                result.Remove_Tools = (string)rdr["Remove_Tools"];
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}