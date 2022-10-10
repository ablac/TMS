using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Contols
{
    class Settings
    {
        //Database Settings
        public static string Database = "C:\\Users\\Keith\\source\\repos\\TMS\\TMS\\Database\\TMS.mdf";
        public static string Security = "True";
        public static string Source = "(LocalDB)\\MSSQLLocalDB";
        public static string Timeout = "30";

        //Verify User information
        public static Boolean Verify_Login = true;
        public static Boolean Verify_Permissions = true;

        //Do not change
        public static int Emp_ID; 

    }
}
