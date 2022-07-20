using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift
{
    public partial class adminDashboard : Form
    {
        //List to keep item details for tab 2
        private List<string[]> itemList = new List<string[]>();

        string formtxt = "";
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Log Out ?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
            else
            {

            }
            
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

            //Review jobs tab layout----------------------------------------
            jobsTabLayout();
            //Item tab layout ----------------------------------------------------
            itemTabLayout();

            //Set dashboard title
            formtxt = adminDetails.getAdminName();
            this.Text = "Welcome " + formtxt;

            //load data for 1st tab
            loadJobs();

        }

        private void adminDashboard_Resize(object sender, EventArgs e)
        {
            //Review jobs tab layout----------------------------------------
            jobsTabLayout();
            //Item tab layout ----------------------------------------------------
            itemTabLayout();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //Review jobs tab layout----------------------------------------
            jobsTabLayout();
            //Item tab layout ----------------------------------------------------
            itemTabLayout();
        }

        private void testBtn1_Click(object sender, EventArgs e)
        {
            formtxt = adminDetails.getAdminName();
            MessageBox.Show("Admin name: " + formtxt);

            this.Text = "Welcome " + formtxt;
        }

        private void list_jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable accept/reject/delete buttons
            btn_accept.Enabled = true;
            btn_delete.Enabled = true;
            btn_reject.Enabled = true;

            int index = list_jobs.SelectedIndex;
            if (index != -1) { 
                string selectedRec = list_jobs.Items[index].ToString();
                string[] selectedArray = selectedRec.Split(':');
                string jobid = selectedArray[0].Trim();

                SQLCon sqlcon = new SQLCon();
                SqlConnection con = sqlcon.Connect();

                var getDetailsQ = @"select * from job_" + jobid + "_table";
                SqlCommand getDetailsCmd = new SqlCommand(getDetailsQ, con);
                var itemList = new List<int[]>();
                using (SqlDataReader reader = getDetailsCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var jobDet = new int[2];
                        jobDet[0] = int.Parse(reader[0].ToString());
                        jobDet[1] = int.Parse(reader[1].ToString());
                        itemList.Add(jobDet);
                    }
                }

                sqlcon.Disconnect();
                con = sqlcon.Connect();
                group_details.Items.Clear();
                group_details.SuspendLayout();
                foreach (var item in itemList)
                {
                    var getItemQ = @"select itemName from admin_items where itemCode = '" + item[0] + "'";
                    SqlCommand getItemmCmd = new SqlCommand(getItemQ, con);
                    using (SqlDataReader reader = getItemmCmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string itemStr = reader[0].ToString() + " X " + item[1];
                            group_details.Items.Add(itemStr);
                        }

                    }
                }
                group_details.ResumeLayout();
                sqlcon.Disconnect();
            }
            else
            {
                list_items.Items.Clear();
            }

        }

        private void jobsTabLayout()
        {
            list_jobs.Width = (tab_review.Width - 24) / 2;
            list_jobs.Height = (tab_review.Height - 16) / 2;
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_review.Width / 2 + change.X, group_details.Location.Y);
            group_details.Location = newLoc;
            group_details.Width = (tab_review.Width - 24) / 2;
            group_details.Height = tab_review.Height - 16;

            Point manageDisp = new Point(0, 8);
            group_manage.Height = group_details.Height - list_jobs.Height - 8;
            group_manage.Width = list_jobs.Width;
            group_manage.Location = new Point(list_jobs.Location.X, list_jobs.Location.Y+manageDisp.Y+list_jobs.Height);
        }

        private void itemTabLayout()
        {
            list_items.Width = (tab_items.Width - 24) / 2;
            list_items.Height = (tab_items.Height - box_addItem.Height - 24);
            Point change2 = new Point(8, 0);
            Point newLoc2 = new Point(tab_items.Width / 2 + change2.X, box_editItem.Location.Y);
            box_editItem.Location = newLoc2;
            box_editItem.Width = (tab_items.Width - 24) / 2;
        }

        private void loadJobs()
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var getJobsQ = @"select jobid ,usermail, date, status from job_table";
            SqlCommand getJobsCmd = new SqlCommand(getJobsQ, con);
            using (SqlDataReader reader = getJobsCmd.ExecuteReader())
            {
                list_jobs.Items.Clear();
                list_jobs.SuspendLayout();
                while (reader.Read())
                {

                    string jobTxt = reader[0].ToString() + " : " + reader[1].ToString() + " on " + reader[2].ToString() + " - " + reader[3].ToString();
                    list_jobs.Items.Add(jobTxt);
                }
                list_jobs.ResumeLayout();
            }

            sqlcon.Disconnect();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {

            int jobid = int.Parse(list_jobs.SelectedItem.ToString().Split(':')[0].Trim());
            setJobStatus(jobid,"accepted");
            disableManageButtons();
            loadJobs();
        }

        private void setJobStatus(int jobid,string status)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var updateQ = @"update job_table set status = '" + status + "' where jobid = '"+jobid+"'";
            SqlCommand updateCmd = new SqlCommand(updateQ, con);
            try
            {
                
                updateCmd.ExecuteNonQuery();
            }catch(Exception updateEx)
            {
                MessageBox.Show(updateEx.Message);
            }


            sqlcon.Disconnect();

        }
        private void disableManageButtons()
        {
            btn_accept.Enabled = false;
            btn_delete.Enabled = false;
            btn_reject.Enabled = false;
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            int jobid = int.Parse(list_jobs.SelectedItem.ToString().Split(':')[0].Trim());
            setJobStatus(jobid, "rejected");
            disableManageButtons();
            loadJobs();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                SQLCon sqlcon = new SQLCon();
                SqlConnection con = sqlcon.Connect();

                int jobid = int.Parse(list_jobs.SelectedItem.ToString().Split(':')[0].Trim());
                var deleteQ = @"delete from job_table where jobid = '"+jobid+"'";
                SqlCommand deleteCmd = new SqlCommand(deleteQ, con);
                try
                {
                    deleteCmd.ExecuteNonQuery();
                }catch(Exception delEx)
                {
                    MessageBox.Show(delEx.Message);
                }
                var dropQ = @"drop table job_" + jobid + "_table";
                SqlCommand dropCmd = new SqlCommand(dropQ, con);
                try
                {
                    dropCmd.ExecuteNonQuery();
                }catch(Exception dropEx)
                {
                    MessageBox.Show(dropEx.Message);
                }
                sqlcon.Disconnect();
            }
            loadJobs();
            disableManageButtons();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = tabControl1.SelectedIndex;
            if (tabIndex == 0)
            {
                loadJobs();
            }else if (tabIndex == 1)
            {
                loadAdminItems();
            }
        }
        private void loadAdminItems()
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var getItemsQ = "select * from admin_items";
            SqlCommand getItemsCmd = new SqlCommand(getItemsQ, con);
            try
            {
                using(SqlDataReader reader = getItemsCmd.ExecuteReader())
                {
                    list_items.SuspendLayout();
                    list_items.Items.Clear();
                    while (reader.Read())
                    {
                        var itemArray = new string[reader.FieldCount];
                        for(int n = 0; n < reader.FieldCount; n++)
                        {
                            itemArray[n] = reader[n].ToString();
                            
                        }
                        Debug.WriteLine("Price of " + reader[1] + ": " + itemArray[2]);
                        itemList.Add(itemArray);
                        list_items.Items.Add(reader[1]);
                    }
                    list_items.ResumeLayout();
                }

            }catch(Exception sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }

            sqlcon.Disconnect();
        }

        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemName = list_items.SelectedItem.ToString().Trim();
            int index = list_items.SelectedIndex;
            txt_editCode.Text = itemList[index][0];
            txt_editName.Text = itemList[index][1];
            txt_editCost.Text = itemList[index][2].ToString();
            changeEditBox(true);
        }
        private void changeEditBox(bool state)
        {
            //txt_editCode.Enabled = state;
            txt_editCost.Enabled = state;
            txt_editName.Enabled = state;
            btn_update.Enabled = state;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
        private void updateItem(int itemCode,string name,float cost)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var updateQ = @"update admin_items set itemName='" + name + "',unitCost='" + cost + "'";
            SqlCommand updateCmd = new SqlCommand(updateQ, con);
            try
            {
                updateCmd.ExecuteNonQuery();
            }catch(Exception updateEx)
            {
                MessageBox.Show(updateEx.Message);
            }

            sqlcon.Disconnect();
        }
    }
}
