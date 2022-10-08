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

        //Verify Login used for Easy Database debugging
        public static Boolean Verify_Login = true;

        //Do not change
        public static string Emp_ID; 

    }
}
