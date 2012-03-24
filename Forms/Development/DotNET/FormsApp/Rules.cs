using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsApp
{
    public class Rules
    {
        public static bool required(string txt)
        {
            if (txt.Trim() != "")
                return true;
            return false;
        }
        public static bool validEmail(string email)
        {
            return true;
        }

        public static bool validPassword(string password)
        {
            if (password.Length > 5)
                return true;
            else
                return false;
        }
    }
}