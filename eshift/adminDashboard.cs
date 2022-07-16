using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift
{
    public partial class adminDashboard : Form
    {
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
            list_jobs.Width = (tab_review.Width - 24) / 2;
            list_jobs.Height = tab_review.Height - 16;
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_review.Width / 2 + change.X, group_details.Location.Y);
            group_details.Location = newLoc;
            group_details.Width = (tab_review.Width - 24) / 2;
            //Item tab layout ----------------------------------------------------
            list_items.Width = (tab_items.Width - 24) / 2;
            list_items.Height = (tab_items.Height - box_addItem.Height - 24);
            Point change2 = new Point(8, 0);
            Point newLoc2 = new Point(tab_items.Width / 2 + change2.X, box_editItem.Location.Y);
            box_editItem.Location = newLoc2;
            box_editItem.Width = (tab_items.Width - 24) / 2;

        }

        private void adminDashboard_Resize(object sender, EventArgs e)
        {
            //Review jobs tab layout----------------------------------------
            list_jobs.Width = (tab_review.Width - 24) / 2;
            list_jobs.Height = tab_review.Height - 16;
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_review.Width / 2 + change.X, group_details.Location.Y);
            group_details.Location = newLoc;
            group_details.Width = (tab_review.Width - 24) / 2;
            //Item tab layout ----------------------------------------------------
            list_items.Width = (tab_items.Width - 24) / 2;
            list_items.Height = (tab_items.Height - box_addItem.Height - 24);
            Point change2 = new Point(8, 0);
            Point newLoc2 = new Point(tab_items.Width / 2 + change2.X, box_editItem.Location.Y);
            box_editItem.Location = newLoc2;
            box_editItem.Width = (tab_items.Width - 24) / 2;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //Review jobs tab layout----------------------------------------
            list_jobs.Width = (tab_review.Width - 24) / 2;
            list_jobs.Height = tab_review.Height - 16;
            Point change = new Point(8, 0);
            Point newLoc = new Point(tab_review.Width / 2 + change.X, group_details.Location.Y);
            group_details.Location = newLoc;
            group_details.Width = (tab_review.Width - 24) / 2;
            //Item tab layout ----------------------------------------------------
            list_items.Width = (tab_items.Width - 24) / 2;
            list_items.Height = (tab_items.Height - box_addItem.Height - 24);
            Point change2 = new Point(8, 0);
            Point newLoc2 = new Point(tab_items.Width / 2 + change2.X, box_editItem.Location.Y);
            box_editItem.Location = newLoc2;
            box_editItem.Width = (tab_items.Width - 24) / 2;
        }
    }
}
