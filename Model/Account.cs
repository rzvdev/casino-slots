using System;
using System.Collections.Generic;
using System.Text;

namespace SizzlingHot
{
    class Account
    {
        public static Account LoggedAccount { get; set; }
        public static bool LoggedIn { get; set; }
        
        public static bool IsRoot{get; set;}
        public static string User { get; set; }
        public static string Password { get; set; }

        public Account(string user, string password)
        {
            User = user;
            Password = password;
        }

        public Account(){}

        public static void Login(Account a)
        {
            LoggedAccount = a;
            LoggedIn = true;
        }

        public static void Logout()
        {
            LoggedIn = false;
            LoggedAccount = null;
            IsRoot = false;
            User = "";
            Password = "";
        }
    }
}
