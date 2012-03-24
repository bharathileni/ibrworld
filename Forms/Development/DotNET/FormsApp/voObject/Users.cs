using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsApp.voObject
{
    public class Users
    {
        private long userId;
        private string emailId;
        private string encryptPassword;
        private string status;

        public long UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        public string EmailId
        {
            get
            {
                return emailId;
            }
            set
            {
                emailId = value;
            }
        }

        public string EncryptPassword
        {
            get
            {
                return encryptPassword;
            }
            set
            {
                encryptPassword = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

    }
}