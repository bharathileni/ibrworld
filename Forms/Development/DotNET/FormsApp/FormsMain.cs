using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsApp
{
    public class FormsMain:Validation
    {
        public FormsMain()
        {
            UserSession session = UserSession.GetSession(Session);
            if (session != null && session.Users != null)
            {
                Response.Redirect("index.html");
            }
        }
    }
}