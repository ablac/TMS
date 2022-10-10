using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Contols
{
    class Permissions
    {
        //Create SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=" + Settings.Source + ";AttachDbFilename=" + Settings.Database + ";Integrated Security=" + Settings.Security + ";Connect Timeout=" + Settings.Timeout);

        void verify()
        {
            List<String> Data = new List<String>();
            using (SqlConnection con = new SqlConnection("Con_String"))
            {
                con.Open();
                string query = "Select * from Permissions where Emp_ID = '" + Settings.Emp_ID;
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Data.Add(reader.GetString(0));
                        }
                    }
                }
            }
            MessageBox.Show(Data[0]);
            MessageBox.Show(Data[1]);
            MessageBox.Show(Data[2]);
            MessageBox.Show(Data[3]);
            MessageBox.Show(Data[4]);
            MessageBox.Show(Data[5]);
            MessageBox.Show(Data[6]);
            MessageBox.Show(Data[7]);
            MessageBox.Show(Data[8]);
            MessageBox.Show(Data[9]);
            MessageBox.Show(Data[10]);
        }
    }
}
