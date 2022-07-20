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
    public partial class form_userLogin : Form
    {
        public form_userLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Validations here
            String email = textEmail.Text.Trim();
            String pass = textPass.Text.Trim();
            bool valid = false;
            if(email!=null && email!="" && pass!=null && pass != "")
            {
                SQLCon sqlcon = new SQLCon();
                SqlConnection con = sqlcon.Connect();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    String validateQ = @"select * from user_table where email = '"+email+"' and pass = '"+pass+"'";
                    SqlCommand validateCmd = new SqlCommand(validateQ, con);
                    using(SqlDataReader reader = validateCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if(reader[0].ToString()==email && reader[1].ToString() == pass)
                            {
                                //save user details to static class
                                UserDetails.setUserMail(email);
                                UserDetails.setFname(reader[2].ToString());
                                valid = true;
                                break;
                            }
                        }
                        if (!valid)
                        {
                            MessageBox.Show("Invalid username/password!");
                        }
                    }

                    sqlcon.Disconnect();
                }
                else
                {
                    MessageBox.Show("Error connecting to SQL database!");
                }
               
            }
            else
            {
                MessageBox.Show("All fields must be filled!");
            }

            if (valid)
            {
                
                //if valid godi dashboard
                form_userDashboard uDash = new form_userDashboard();
                uDash.Show(this.Owner);
                this.Close();
            }
        }

        private void form_userLogin_Load(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
