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
    public partial class form_userSignup : Form
    {
        public form_userSignup()
        {
            InitializeComponent();
        }

        public Welcome Welcome
        {
            get => default;
            set
            {
            }
        }

        private void form_userSignup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textFname.Text.Trim();
            String lname = textLname.Text.Trim();
            String email = textEmail.Text.Trim();
            String pass = textPass.Text.Trim();

            if(fname!=null && lname!=null && email!=null && pass != null && fname != "" && lname != "" && email != "" && pass != "")
            {
                SQLCon sqlcon = new SQLCon();
                SqlConnection con = sqlcon.Connect();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    var insQ = @"insert into user_table values ('"+email+"','"+pass+"','"+fname+"','"+lname+"')";
                    SqlCommand insCmd = new SqlCommand(insQ, con);
                    int res = insCmd.ExecuteNonQuery();
                    MessageBox.Show("Added " + res + " rows");
                    this.Owner.Show();
                    sqlcon.Disconnect();
                    this.Close();
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
        }
    }
}
