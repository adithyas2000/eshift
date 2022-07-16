using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eshift
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void rad_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_admin.Checked)
            {
                btn_signup.Enabled = false;
            }
            else
            {
                btn_signup.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad_admin.Checked = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (rad_user.Checked)
            {
                form_userLogin ulogin=new form_userLogin();
                this.Hide();
                ulogin.Show(this);
            }else if (rad_admin.Checked)
            {
                form_adminLogin alogin = new form_adminLogin();
                this.Hide();
                alogin.Show(this);
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            form_userSignup usignup = new form_userSignup();
            this.Hide();
            usignup.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itest = "chair X 3";
            string[] splitText = itest.Split('X');
            Debug.WriteLine("1 : " + splitText[0]);
            Debug.WriteLine("2 : " + splitText[1]);
        }
    }
}
