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
                adminDetails.clear();
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
            

            int index = list_jobs.SelectedIndex;
            if (index != -1) { 
                btn_accept.Enabled = true;
                btn_delete.Enabled = true;
                btn_reject.Enabled = true;
                btn_finished.Enabled = true;

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
                disableManageButtons();
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
            btn_finished.Enabled = false;
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
            }else if (tabIndex == 3)
            {
                loadAdminDetails();
            }else if (tabIndex == 4)
            {
                refreshDatagrid();
            }else if (tabIndex == 2)
            {
                refreshCities();
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
                itemList.Clear();
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
            updateNewItemcode();
            changeEditBox(false);
        }

        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_items.SelectedIndex != -1)
            {
                
                string itemName = list_items.SelectedItem.ToString().Trim();
                int index = list_items.SelectedIndex;
                txt_editCode.Text = itemList[index][0];
                txt_editName.Text = itemList[index][1];
                txt_editCost.Text = itemList[index][2].ToString();

                if (itemList[index][4].ToString().Trim().Equals("available"))
                {
                    check_available.Checked = true;
                }
                else
                {
                    check_available.Checked = false;
                    Debug.WriteLine("Check: " + itemList[index][4].ToString());
                }
                changeEditBox(true);
            }
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
            int itemcode = int.Parse(txt_editCode.Text.Trim());
            string name = txt_editName.Text;
            float cost = float.Parse(txt_editCost.Text.Trim());
            
            updateItem(itemcode, name, cost,check_available.Checked);
            loadAdminItems();
            changeEditBox(false);
        }
        private void updateItem(int itemCode,string name,float cost,bool available)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();
            string state = "unavail";
            if (available)
            {
                state = "available";
            }
            else
            {
                state = "unavail";
            }
            var updateQ = @"update admin_items set itemName='" + name + "',unitCost='" + cost + "',state='"+state+"' where itemCode='"+itemCode+"'";
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();
            int lastIndex = 0;
            var getLatIndexQ = @"select top 1 * from admin_items order by itemCode desc";
            SqlCommand getLastIndexCmd = new SqlCommand(getLatIndexQ, con);
            using(SqlDataReader reader = getLastIndexCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lastIndex = int.Parse(reader[0].ToString());
                }
            }

            var addItemQ = @"insert into admin_items values(" + (lastIndex + 1) + ",'" + txt_newName.Text + "','" + txt_newCost.Text + "','NULL','available')";
            SqlCommand addItemCmd = new SqlCommand(addItemQ, con);
            addItemCmd.ExecuteNonQuery();

            sqlcon.Disconnect();
            loadAdminItems();
        }

        private void updateNewItemcode()
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var getItemCodeQ= @"select top 1 * from admin_items order by itemCode desc";
            SqlCommand getItemCodeCmd = new SqlCommand(getItemCodeQ, con);
            using(SqlDataReader reader = getItemCodeCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    txt_newCode.Text = (int.Parse(reader[0].ToString())+1).ToString();
                    Debug.WriteLine("Last item code: " + (reader[0].ToString()));
                }
            }

            sqlcon.Disconnect();
        }
        private void loadAdminDetails()
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con=sqlcon.Connect();

            var getAdminQ = @"select * from admin_table where email='" + adminDetails.getAdminMail() + "'";
            SqlCommand getAdminCmd = new SqlCommand(getAdminQ, con);
            using(SqlDataReader reader = getAdminCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    txt_editMail.Text = reader[0].ToString();
                    txt_editAdminPass.Text = reader[1].ToString();
                    txt_editAdminName.Text = reader[2].ToString();
                }
            }

            sqlcon.Disconnect();
            txt_editAdminPass.Enabled = false;
            txt_editAdminName.Enabled = false;
        }

        private void link_editName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_editAdminName.Enabled = true;
        }

        private void link_editPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_editAdminPass.Enabled = true;
        }

        private void btn_updateAdmin_Click(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var updateAdminQ = @"update admin_table set fname='" + txt_editAdminName.Text + "',pass='" + txt_editAdminPass.Text + "' where email='" + adminDetails.getAdminMail() + "'";
            SqlCommand updateAdminCmd = new SqlCommand(updateAdminQ, con);
            try
            {
                updateAdminCmd.ExecuteNonQuery();
            }catch(Exception updateEx)
            {
                MessageBox.Show(updateEx.Message);
            }

            sqlcon.Disconnect();
            txt_editAdminName.Enabled = false;
            txt_editAdminPass.Enabled = false;
        }

        private void btn_finished_Click(object sender, EventArgs e)
        {
            int jobid = int.Parse(list_jobs.SelectedItem.ToString().Split(':')[0].Trim());
            setJobStatus(jobid, "finished");
            disableManageButtons();
            loadJobs();
        }

        private void refreshDatagrid()
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            //Data for all users details
            if (rad_allUsers.Checked)
            {
                //set columns of datagrid
                data_report.Columns.Clear();
                data_report.Columns.Add("email", "Email");
                data_report.Columns.Add("fname", "First Name");
                data_report.Columns.Add("lname", "Last name");
                data_report.Columns.Add("jobCount", "Number of Jobs");

                //list to store records temporarily
                var recList = new List<string[]>();

                
                var readUsersQ = @"select fname,lname,email from user_table";
                SqlCommand readUsersCmd = new SqlCommand(readUsersQ, con);
                try
                {
                    using(SqlDataReader reader = readUsersCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var userData = new string[4];
                            for (int n = 0; n < 3; n++)
                            {
                                
                                userData[n] = reader[n].ToString();
                            }
                            recList.Add(userData);
                        }
                    }
                    sqlcon.Disconnect();

                    con = sqlcon.Connect();

                    foreach (var rec in recList)
                    {
                        string usermail = rec[2];
                        int count = 0;
                        var getJobCountQ = @"select usermail from job_table where usermail='" + usermail + "'";
                        SqlCommand getJobCountCmd = new SqlCommand(getJobCountQ, con);
                        using(SqlDataReader reader= getJobCountCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                count++;
                            }
                            rec[3] = count.ToString();
                        }
                    }
                    
                    
                    
                }catch(Exception readEx)
                {
                    MessageBox.Show(readEx.Message);
                }
                data_report.SuspendLayout();
                data_report.Rows.Clear();
                foreach (var rec in recList)
                {
                    data_report.Rows.Add(rec);

                }
                data_report.ResumeLayout();
            }else if (rad_allJobs.Checked)
            {
                //set columns of datagrid view
                data_report.Columns.Clear();
                data_report.Columns.Add("jobid", "Job ID");
                data_report.Columns.Add("usermail", "User Email");
                data_report.Columns.Add("fromLoc", "From");
                data_report.Columns.Add("toLoc", "To");
                data_report.Columns.Add("date", "Job Date");
                data_report.Columns.Add("status", "Status");

                //temp list for records
                var recList = new List<string[]>();

                var getJobsQ = "select * from job_table";
                SqlCommand getJobsCmd = new SqlCommand(getJobsQ, con);
                try
                {
                    using(SqlDataReader reader = getJobsCmd.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {   var dataArray = new string[6];
                            for(int n = 0; n < 6; n++)
                            {
                                dataArray[n] = reader[n].ToString();
                            }
                            recList.Add(dataArray);
                        }
                    }

                }catch(Exception readEx)
                {
                    MessageBox.Show(readEx.Message);
                }

                //add records to datagrid
                data_report.Rows.Clear();
                foreach (var rec in recList)
                {
                    data_report.Rows.Add(rec);
                }
            }else if (radFinishedJobs.Checked)
            {
                //set columns of datagrid view
                data_report.Columns.Clear();
                data_report.Columns.Add("jobid", "Job ID");
                data_report.Columns.Add("usermail", "User Email");
                data_report.Columns.Add("fromLoc", "From");
                data_report.Columns.Add("toLoc", "To");
                data_report.Columns.Add("date", "Job Date");
                data_report.Columns.Add("status", "Status");

                //temp list for records
                var recList = new List<string[]>();

                var getJobsQ = "select * from job_table where status='finished'";
                SqlCommand getJobsCmd = new SqlCommand(getJobsQ, con);
                try
                {
                    using (SqlDataReader reader = getJobsCmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var dataArray = new string[6];
                            for (int n = 0; n < 6; n++)
                            {
                                dataArray[n] = reader[n].ToString();
                            }
                            recList.Add(dataArray);
                        }
                    }

                }
                catch (Exception readEx)
                {
                    MessageBox.Show(readEx.Message);
                }

                //add records to datagrid
                data_report.Rows.Clear();
                foreach (var rec in recList)
                {
                    data_report.Rows.Add(rec);
                }
            }
            
            sqlcon.Disconnect();
        }

        private void rad_allUsers_CheckedChanged(object sender, EventArgs e)
        {
            refreshDatagrid();
        }

        private void rad_allJobs_CheckedChanged(object sender, EventArgs e)
        {
            refreshDatagrid();
        }

        private void check_available_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void refreshCities()
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var getCitiesQ = "select * from city_table";
            SqlCommand getCityCmd = new SqlCommand(getCitiesQ, con);
            try
            {
                using(SqlDataReader reader = getCityCmd.ExecuteReader())
                {
                    list_cities.Items.Clear();
                    list_cities.SuspendLayout();
                    while (reader.Read())
                    {
                        list_cities.Items.Add(reader[0].ToString().Trim());
                    }
                    list_cities.ResumeLayout();
                }
            }
            catch (Exception cityEx)
            {
                MessageBox.Show(cityEx.Message);
            }

            sqlcon.Disconnect();
        }

        private void list_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_cities.SelectedIndex != -1)
            {
                btn_removeCity.Enabled = true;
            }
            else
            {
                btn_removeCity.Enabled = false;
            }
        }

        private void btn_removeCity_Click(object sender, EventArgs e)
        {
            string selectedCity = list_cities.SelectedItem.ToString().Trim();
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var delCityQ = "delete from city_table where cityName='" + selectedCity + "'";
            SqlCommand delCityCmd = new SqlCommand(delCityQ, con);
            try
            {
                delCityCmd.ExecuteNonQuery();
            }
            catch (Exception delEx)
            {
                MessageBox.Show(delEx.Message);
            }

            sqlcon.Disconnect();
            refreshCities();
            btn_removeCity.Enabled = false;
        }

        private void txt_cityNew_TextChanged(object sender, EventArgs e)
        {
            if ((txt_cityNew.Text != "")&&(txt_cityNew.Text!=null))
            {
                btn_addCity.Enabled = true;
            }
            else
            {
                btn_addCity.Enabled = false;
            }
        }

        private void btn_addCity_Click(object sender, EventArgs e)
        {
            SQLCon sqlcon = new SQLCon();
            SqlConnection con = sqlcon.Connect();

            var newCityQ = @"insert into city_table values ('" + txt_cityNew.Text + "')";
            SqlCommand newCityCmd = new SqlCommand(newCityQ, con);
            try
            {
                newCityCmd.ExecuteNonQuery();
            }
            catch (Exception cityEx)
            {
                MessageBox.Show(cityEx.Message);
            }
            txt_cityNew.Text = "";
            sqlcon.Disconnect();
            refreshCities();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            refreshDatagrid();
        }
    }
}
