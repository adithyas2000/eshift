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
using System.Globalization;
using System.Data.SqlClient;

namespace eshift
{
    public partial class form_userDashboard : Form
    {
        private float total = 0;
        public form_userDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Log Out ?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
                UserDetails.clear();
            }
            else
            {

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btn_req_Click(object sender, EventArgs e)
        {
            //Add job to requested jobs table

            string startCity = combo_startCity.Text;
            string endCity = combo_endCity.Text;
            DateTime date = date_add.Value;

            if (startCity.Trim() != "" && endCity.Trim() != "" && date != null && list_items.Items.Count > 0)
            {
                int jobid = 0;
                var getLastRecQ = @"select top 1 * from job_table order by jobid desc";

                SQLCon sqlcon = new SQLCon();
                SqlConnection con = sqlcon.Connect();
                SqlCommand getLastRecCmd = new SqlCommand(getLastRecQ, con);
                using (SqlDataReader reader = getLastRecCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jobid = int.Parse(reader[0].ToString());
                    }
                }

                var insertNewJobQ = @"insert into job_table values (" + (jobid + 1) + ",'" + UserDetails.getUsermail() + "','"+combo_startCity.Text+"','"+combo_endCity.Text+"','"+date_add.Text+"','pending')";
                SqlCommand insertNewJobCmd = new SqlCommand(insertNewJobQ, con);
                int res = insertNewJobCmd.ExecuteNonQuery();
                MessageBox.Show("Inserted " + res + " recs");

                var createJobTableQ = @"create table job_" + (jobid + 1) + "_table (itemCode int NOT NULL PRIMARY KEY,count int NOT NULL)";
                SqlCommand createJobTableCmd = new SqlCommand(createJobTableQ, con);
                try
                {
                    createJobTableCmd.ExecuteNonQuery();
                    //Get list of items from list_box and save to an array
                    
                    List<int[]> itemlist = new List<int[]>();

                    int listBoxCount = list_items.Items.Count;
                    foreach (string item in list_items.Items)
                    {
                        string[] splitItem = item.Split('X');
                        string itemName = splitItem[0].Trim();
                        var searchQ = @"select itemCode from admin_items where itemName = '"+itemName+"'";
                        SqlCommand searchCmd = new SqlCommand(searchQ, con);
                        using (SqlDataReader reader = searchCmd.ExecuteReader())
                        {
                            int[] itemArray = new int[2];
                            while (reader.Read())
                            {
                                
                                itemArray[0] = int.Parse(reader[0].ToString());
                                Debug.WriteLine("Found from admin_items : " + itemArray[0].ToString());
                            }
                            itemArray[1] = int.Parse(splitItem[1].Split('-')[0].Trim());
                            itemlist.Add(itemArray);
                        }
                        
                    }

                    int listSize = itemlist.Count;
                    string allRecs = "";
                    for(int c = 0; c < listSize; c++)
                    {
                        //Debug.WriteLine("Rec from list : " + (itemlist[c])[0]);
                        allRecs +="("+ itemlist[c][0].ToString();
                        allRecs += ",";
                        allRecs += itemlist[c][1].ToString()+")";
                        if (c != listSize - 1)
                        {
                            allRecs += ",";
                        }
                    }
                    Debug.WriteLine("ALL RECS : " + allRecs);
                    var insertQ = @"insert into job_" + (jobid + 1) + "_table values "+allRecs+"";
                    SqlCommand insertCmd = new SqlCommand(insertQ, con);
                    int res2 = insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Added " + res2 + " recs to job table");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error creating table : " + ex.ToString());
                }



                sqlcon.Disconnect();
            }
            else
            {
                MessageBox.Show("Fill all fields!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_selectItem_Click(object sender, EventArgs e)
        {
            itemDialog idialog = new itemDialog();

            if (idialog.ShowDialog(this) == DialogResult.OK)
            {
                Debug.WriteLine("Dialog OK");
                Debug.WriteLine("Dialog result : " + idialog.resText);
                bool repeating = false;
                string addString = "";
                string removeItem = "";
                foreach (string item in list_items.Items)
                {
                    string[] iarray = item.Split('X');
                    Debug.WriteLine("Found item: " + item);
                    if (idialog.resText.Contains(iarray[0]))
                    {
                        String[] dialogArray = idialog.resText.Split('X');
                        int increment = int.Parse(dialogArray[1], NumberStyles.AllowLeadingWhite);
                        Debug.WriteLine("Increment : " + increment.ToString());

                        String[] initArray = item.Split('X');
                        int init = int.Parse(initArray[1].Split('-')[0].Trim(), NumberStyles.AllowLeadingWhite);
                        Debug.WriteLine("Init : " + init.ToString());

                        int final = init + increment;
                        //Calculate subtotal for item
                        float subtot = calcSubtot(idialog.iCode, final);
                        String finStr = final.ToString();
                        Debug.WriteLine("Final : " + finStr);

                        addString = iarray[0].Trim() + " X " + finStr+"     ---     Rs."+subtot;
                        total = total + subtot - calcSubtot(idialog.iCode,init);
                        removeItem = item;
                        repeating = true;
                    }

                }
                if (!repeating)
                {
                    //calculate subtotal
                    string[] idialogArray = idialog.resText.Split('X');
                    int iCode = idialog.iCode;
                    int count = int.Parse(idialogArray[1].ToString());
                    float subtot = calcSubtot(iCode, count);
                    string addStr = idialog.resText + "     ---     Rs." + subtot;
                    total += subtot;
                    list_items.Items.Add(addStr);
                }
                else
                {
                    list_items.Items.Remove(removeItem);
                    list_items.Items.Add(addString);
                    repeating = false;
                }
                lbl_total.Text = "Total: Rs." + total;

            }
        }

        private void form_userDashboard_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void form_userDashboard_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void form_userDashboard_Resize(object sender, EventArgs e)
        {
            list_jobs.Width = (tab_jobs.Width - 24) / 2;
            list_jobs.Height = (tab_jobs.Height - 16);
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_jobs.Width / 2 + change.X, box_job.Location.Y);
            box_job.Location = newLoc;
            box_job.Width = (tab_jobs.Width - 24) / 2;
            box_job.Height = (tab_jobs.Height - 16);
        }

        private void form_userDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eshiftDatabaseDataSet.adminTable' table. You can move, or remove it, as needed.
            this.Text ="Welcome "+ UserDetails.getFname();
            list_jobs.Width = (tab_jobs.Width - 24) / 2;
            list_jobs.Height = (tab_jobs.Height - 16);
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_jobs.Width / 2 + change.X, box_job.Location.Y);
            box_job.Location = newLoc;
            box_job.Width = (tab_jobs.Width - 24) / 2;


            //load data
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();



            sqlcon.Disconnect();

        }

        private void tab_account_Click(object sender, EventArgs e)
        {
            list_jobs.Width = (tab_jobs.Width - 24) / 2;
            list_jobs.Height = (tab_jobs.Height - 16);
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_jobs.Width / 2 + change.X, box_job.Location.Y);
            box_job.Location = newLoc;
            box_job.Width = (tab_jobs.Width - 24) / 2;
        }

        private void link_fname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_fname.Enabled = true;
        }

        private void link_lname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_lname.Enabled = true;
        }

        private void link_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_pass.Enabled = true;
        }

        private void form_userDashboard_Click(object sender, EventArgs e)
        {
            list_jobs.Width = (tab_jobs.Width - 24) / 2;
            list_jobs.Height = (tab_jobs.Height - 16);
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_jobs.Width / 2 + change.X, box_job.Location.Y);
            box_job.Location = newLoc;
            box_job.Width = (tab_jobs.Width - 24) / 2;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            list_jobs.Width = (tab_jobs.Width - 24) / 2;
            list_jobs.Height = (tab_jobs.Height - 16);
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_jobs.Width / 2 + change.X, box_job.Location.Y);
            box_job.Location = newLoc;
            box_job.Width = (tab_jobs.Width - 24) / 2;
        }

        private void tab_add_Click(object sender, EventArgs e)
        {

        }

        private void tab_add_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("Loaded enter tab");
        }

        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_removeItem.Enabled = true;
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            list_items.Items.Remove(list_items.SelectedItem);
            btn_removeItem.Enabled = false;
        }

        private void combo_startCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_startCity_DropDown(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            String cityQ = "select cityName from city_table";
            SqlCommand cityCmd = new SqlCommand(cityQ, con);

            combo_startCity.Items.Clear();

            using (SqlDataReader reader = cityCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    combo_startCity.SuspendLayout();
                    combo_startCity.Items.Add(reader[0]);
                    combo_startCity.ResumeLayout();
                }
            }

            sqlcon.Disconnect();
        }

        private void combo_endCity_DropDown(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            String cityQ = "select cityName from city_table";
            SqlCommand cityCmd = new SqlCommand(cityQ, con);

            combo_endCity.Items.Clear();

            using (SqlDataReader reader = cityCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    combo_endCity.SuspendLayout();
                    combo_endCity.Items.Add(reader[0]);
                    combo_endCity.ResumeLayout();
                }
            }

            sqlcon.Disconnect();
        }

        private void testBtn1_Click(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con= sqlcon.Connect();
            
            //for(int n = 7; n < 21; n++)
            //{
            //    var qu = @"drop table job_" + n + "_table";
            //    SqlCommand cmd = new SqlCommand(qu, con);
            //    cmd.ExecuteNonQuery();
            //}

            sqlcon.Disconnect();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            int tabIndex = tabControl1.SelectedIndex;
            //MessageBox.Show("Tabindex: " + tabIndex);
            
            if (tabIndex == 1) 
            {//load data to 2nd tab if clicked on 2nd tab
                list_jobs.Items.Clear();
                var selectQ = @"select jobid,fromLoc,toLoc,date,status from job_table where usermail = '"+UserDetails.getUsermail()+"'";
                SqlCommand selectCmd = new SqlCommand(selectQ, con);

                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string jobText = reader[0].ToString()+": "+reader[1].ToString()+" TO "+reader[2]+" ON "+reader[3]+" : "+reader[4];
                        list_jobs.Items.Add(jobText);
                    }
                }
            }else if (tabIndex == 2)
                //load user data if tab 3 loaded
            {

                string usermail = UserDetails.getUsermail();
                var selectQ = @"select * from user_table where email='" + usermail + "'";
                SqlCommand selectCmd = new SqlCommand(selectQ, con);
                using(SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txt_email.Text = reader[0].ToString();
                        txt_fname.Text = reader[2].ToString();
                        txt_lname.Text = reader[3].ToString();
                        txt_pass.Text = reader[1].ToString();
                    }
                }
            }

            sqlcon.Disconnect();
        }

        private void list_jobs_SelectedValueChanged(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            string selectedJob = list_jobs.SelectedItem.ToString();
            string[] selectedJobSplit = selectedJob.Split(':');
            int jobid = int.Parse(selectedJobSplit[0]);

            var selectQ = @"select * from job_"+jobid+"_table";
            SqlCommand selectCmd =new SqlCommand(selectQ, con);
            using(SqlDataReader reader = selectCmd.ExecuteReader())
            {
                box_job.Items.Clear();
                while (reader.Read())
                {
                    int itemcode = int.Parse(reader[0].ToString());
                    string itemName = "";
                    var getItemQ = @"select itemName from admin_items where itemCode = '" + itemcode + "'";
                    //create new temporary connection to server
                    SQLCon sqlcon2 = new SQLCon();
                    SqlConnection con2 = sqlcon2.Connect();
                    SqlCommand getItemCmd = new SqlCommand(getItemQ, con2);
                    using(SqlDataReader reader2 = getItemCmd.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            itemName = reader2[0].ToString();
                        }
                    }
                    sqlcon2.Disconnect();
                    string itemText = itemName + " X " + reader[1].ToString();
                    box_job.Items.Add(itemText);
                }
            }


            sqlcon.Disconnect();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string fname = txt_fname.Text;
            string lname = txt_lname.Text;
            string usermail = txt_email.Text;
            string pass = txt_pass.Text;
            var updateUserQ = @"update user_table set pass = '"+pass+"',fname = '"+fname+"',lname = '"+lname+"' where email = '"+usermail+"'";
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();
            SqlCommand updateCmd = new SqlCommand(updateUserQ, con);
            int res = updateCmd.ExecuteNonQuery();
            //MessageBox.Show("Updated " + res + " records");
            sqlcon.Disconnect();
            txt_email.Enabled = false;
            txt_fname.Enabled = false;
            txt_lname.Enabled = false;
            txt_pass.Enabled = false;
        }

        public float calcSubtot(int iCode,int count)
        {
            float subtot = 0;
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();
            var getPricesQ = @"select unitCost from admin_items where itemCode = "+iCode+"";
            SqlCommand getPriceCmd = new SqlCommand(getPricesQ, con);
            using(SqlDataReader reader = getPriceCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    subtot = float.Parse(reader[0].ToString()) * count;
                }
            }
            sqlcon.Disconnect();
            return subtot;

        }
    }
}
