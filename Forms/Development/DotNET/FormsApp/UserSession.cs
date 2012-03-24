using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using FormsApp.voObject;

namespace FormsApp
{
    public class UserSession
    {
        const string sessionIndex = "UserSession";

        public static UserSession GetSession(HttpSessionState session)
        {
            // if not there create it
            if (session[sessionIndex] == null)
                session.Add(sessionIndex, new UserSession());

            return (UserSession)session[sessionIndex];
        }

        private Users users;
        public Users Users
        {
            get
            {
                return users;
            }
            set
            {
                users = value;
            }
        }
    }
}