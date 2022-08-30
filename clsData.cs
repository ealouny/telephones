using System.Data;
using System.Data.SqlClient;

namespace WinFormApps
{
    internal class clsData
    {
        public string conn_string = "Data Source=DESKTOP-SNS8QH5\\SQLEXPRESS;Initial Catalog=Telephone; Integrated Security=SSPI;";
        public string sql_string = "select * from tblTelephones order by Dept";
        public string user_string = "";
    }            
}
