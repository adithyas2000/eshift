//DONE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift
{
    public partial class form_adminLogin : Form
    {
        public form_adminLogin()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con =  sqlcon.Connect();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String email = textEmail.Text;
                String pass = textPassword.Text;
                bool valid = false;
                //MessageBox.Show("Connected to the SQL database successfully");
                String validateQ = @"select * from admin_table where email ='" + email + "' ";
                SqlCommand validateCmd = new SqlCommand(validateQ, con);
                using(SqlDataReader reader = validateCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == email && reader[1].ToString()==pass)
                        {
                            //If validation successful, procees to admin dashboard
                            valid = true;

                            adminDashboard adminDash = new adminDashboard();
                            
                            adminDetails.setAdminMail(email);
                            adminDetails.setAdminName(reader[2].ToString());
                            adminDash.Show(this.Owner);
                            sqlcon.Disconnect();
                            
                            this.Close();
                            break;
                        }
                    }
                    if (!valid){
                        MessageBox.Show("Invalid username/password!");
                    }
                    
                    valid = false;

                }
            }
            else
            {
                MessageBox.Show("Failed connecting to SQL database!");
            }
            
        }
    }
}
