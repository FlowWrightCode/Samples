using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Code_App
{
    public class clsModGlobal
    {
        public static string getConnStr()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connectString"].ConnectionString;
            return (connStr);
        }
    }
}
