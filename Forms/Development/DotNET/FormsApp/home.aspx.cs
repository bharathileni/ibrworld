using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsApp
{
    public partial class home : FormsMain
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserSession session = UserSession.GetSession(Session);
            welcomeLabel.Text = session.Users.EmailId;
        }

        protected void signoutLinkButton_Click(object sender, EventArgs e)
        {
            UserSession session = UserSession.GetSession(Session);
            session = null;
        }
    }
}