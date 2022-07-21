using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace eshift
{
    public partial class itemDialog : Form
    {
        public string resText = "";
        public int iCode = 0;
        public itemDialog()
        {
            InitializeComponent();
        }

        private void itemDialog_Load(object sender, EventArgs e)
        {
            //Add items from DB to combo box here
            SQLCon sqlcon = new SQLCon();
            SqlConnection con =  sqlcon.Connect();

            String selectQ = "select * from admin_items where state='available'";
            SqlCommand selectCmd = new SqlCommand(selectQ, con);
            int len = 0;
            bool recFound = false;
            using(SqlDataReader reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    len++;
                }
                if (len > 0)
                {
                    recFound = true;
                }
            }

            if (recFound)
            {
                int n= 0;
                String[] itemList = new string[len];
                using(SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        itemList[n] = reader[1].ToString();
                        n++;
                    }
                }
                combo_item.Items.AddRange(itemList);
            }

            sqlcon.Disconnect();
            //String[] itemList = new string[];
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (combo_item.Text.Trim() != "")
            {
                String itemName = combo_item.Text;
                String count = num_items.Value.ToString();
                resText = itemName + " X " + count;

                SQLCon sqlcon = new SQLCon();
                SqlConnection con = sqlcon.Connect();
                var getICodeQ = @"select itemCode from admin_items where itemName = '"+itemName.Trim()+"'";
                SqlCommand getICodeCmd = new SqlCommand(getICodeQ, con);
                using(SqlDataReader reader = getICodeCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        iCode = int.Parse(reader[0].ToString());
                    }
                }

                sqlcon.Disconnect();
            
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Select an item to add!");
            }
           
        }
    }
}
