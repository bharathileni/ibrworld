using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsApp
{
    public class Validation:BaseObject
    {
        protected bool isLoginValid(string email,string password)
        {
            return true;
                
            /*if (Rules.validEmail(email) && Rules.validPassword(password))
            {
                return true;
            }
            return false;*/
        }
    }
}