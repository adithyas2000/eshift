using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift
{
    internal static class adminDetails
    {
        private static string adminMail = "";
        private static string adminName = "";

        public static adminDashboard Admin_Details
        {
            get => default;
            set
            {
            }
        }

        public static void setAdminMail(string mail)
        {
            adminMail = mail;
        }

        public static void setAdminName(string name)
        {
            adminName = name;
        }

        public static string getAdminMail()
        {
            return adminMail;
        }

        public static string getAdminName()
        {
            return adminName;
        }

        public static void clear()
        {
            setAdminMail("");
            setAdminName("");
        }
    }
}
