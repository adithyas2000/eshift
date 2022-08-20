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
        //exporting SqlConnetion object
        private SqlConnection con=null;
        //Connection string for SQL Databse
        public String cString = "Data Source=DESKTOP-CJ5H4TK;Initial Catalog=EshiftDatabase;Integrated Security=True";

        public adminDashboard SQL_Connection
        {
            get => default;
            set
            {
            }
        }

        public form_userDashboard SQL_Connection2
        {
            get => default;
            set
            {
            }
        }

        //Initialize a connection to dba d return sqlconnection obj
        public SqlConnection Connect()
        {
            con = new SqlConnection(cString);
            con.Open();
            return con;
        }

        //Disconnect the connection started by the current instance
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
