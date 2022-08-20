using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift
{
    internal static class UserDetails
    {
       private static string usermail = "";
       private static string fname = "";

        public static form_userDashboard User_Details
        {
            get => default;
            set
            {
            }
        }

        public static string getUsermail()
        {
            return usermail;
        }

        public static string getFname()
        {
            return fname;
        }

        public static void setUserMail(string mail)
        {
            usermail = mail;
        }

        public static void setFname(string name)
        {
            fname = name;
        }

        //Clear details - call this method on logout
        public static void clear()
        {
            setUserMail("");
            setFname("");
        }
    }
}
