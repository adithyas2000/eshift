using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift
{
    internal class SQLCon
    {
        private SqlConnection con=null;
        public String cString = "Data Source=DESKTOP-CJ5H4TK;Initial Catalog=EshiftDatabase;Integrated Security=True";

        public SqlConnection Connect()
        {
            con = new SqlConnection(cString);
            con.Open();
            return con;
        }

        public SqlConnection Disconnect()
        {
            if(con != null)
            {
                con.Close();
            }
            
            return con;
        }
    }
}
