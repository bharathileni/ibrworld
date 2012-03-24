using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using FormsApp.voObject;

namespace FormsApp
{
    public class Access
    {
        private string connectionString = "Server=localhost;Database=forms;Uid=root;Pwd=admin;";
        public Users authenticate(string email, string password)
        {
            MySqlDataAdapter da=new MySqlDataAdapter("select userId,emailId,encryptPassword,status from users where emailId='"+email+"' and encryptPassword='"+password+"'",connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Users users = new Users();
                users.UserId = (long)dt.Rows[0]["userId"];
                users.EmailId = dt.Rows[0]["emailId"].ToString();
                users.EncryptPassword = dt.Rows[0]["encryptPassword"].ToString();
                users.Status = dt.Rows[0]["status"].ToString();
                return users;
            }
            else
                return null;
        }

        public Users register(string email, string password)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("insert into users(emailId,encryptPassword,status) value('" + email + "','" + password + "','Active')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return authenticate(email, password);
        }

        public bool userAvailable(string email)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select userId,emailId from users where emailId='" + email + "'", connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >0)
            {
                return false;
            }
            return true;
        }
    }
}