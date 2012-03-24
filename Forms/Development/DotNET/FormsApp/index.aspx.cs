using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using FormsApp.voObject;

namespace FormsApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserSession session = UserSession.GetSession(Session);
            if (session.Users != null)
            {
                Response.Redirect("home.aspx");
            }
        }

        protected void loginLinkButton_Click(object sender, EventArgs e)
        {
            clearLoginMessages();
            if (Rules.required(loginEmailTextBox.Text))
            {
                if (Rules.validEmail(loginEmailTextBox.Text))
                {
                    if (Rules.required(loginPasswordTextBox.Text))
                    {
                        if (Rules.validPassword(loginPasswordTextBox.Text))
                        {
                            Access access = new Access();
                            Users users = access.authenticate(loginEmailTextBox.Text, loginPasswordTextBox.Text);
                            if (users != null)
                            {
                                UserSession userSession = UserSession.GetSession(Session);
                                userSession.Users = users;
                                Response.Redirect("home.aspx");
                            }
                            else
                            {
                                loginPasswordMessage.Text = Message.E102;
                            }
                        }
                        else
                        {
                            loginPasswordMessage.Text=Message.E102;
                        }
                    }
                    else
                    {
                        loginPasswordMessage.Text = Message.E100;
                    }
                }
                else
                {
                    loginEmailMessage.Text = Message.E101;
                }
            }
            else
            {
                loginEmailMessage.Text = Message.E100;
            }
        }

        private void clearLoginMessages()
        {
            loginEmailMessage.Text = "";
            loginPasswordMessage.Text = "";
        }

        protected void registerLinkButton_Click(object sender, EventArgs e)
        {
            clearRegisterMessages();
            if (Rules.required(registerEmailTextBox.Text))
            {
                if (Rules.required(registerPasswordTextBox.Text))
                {
                    if (Rules.required(registerConfirmPasswordTextBox.Text))
                    {
                        if (Rules.validEmail(registerEmailTextBox.Text))
                        {
                            if (Rules.validPassword(registerPasswordTextBox.Text))
                            {
                                if (Rules.validPassword(registerConfirmPasswordTextBox.Text))
                                {
                                    if (registerPasswordTextBox.Text == registerConfirmPasswordTextBox.Text)
                                    {
                                        Access access = new Access();
                                        if (access.userAvailable(registerEmailTextBox.Text))
                                        {
                                            Users user=access.register(registerEmailTextBox.Text, registerConfirmPasswordTextBox.Text);
                                            if (user != null)
                                            {
                                                UserSession session = UserSession.GetSession(Session);
                                                session.Users = user;
                                                Response.Redirect("home.aspx");
                                            }
                                            else
                                            {
                                                registerConfirmPasswordMessage.Text = Message.E102;
                                            }
                                        }
                                        else
                                        {
                                            registerConfirmPasswordMessage.Text = Message.E105;
                                        }
                                    }
                                    else
                                    {
                                        registerConfirmPasswordMessage.Text = Message.E103;
                                    }
                                }
                                else
                                {
                                    registerConfirmPasswordMessage.Text = Message.E104;
                                }
                            }
                            else
                            {
                                registerPasswordMessage.Text = Message.E104;
                            }
                        }
                        else
                        {
                            registerEmailMessage.Text = Message.E101;
                        }
                    }
                    else
                    {
                        registerConfirmPasswordMessage.Text = Message.E100;
                    }
                }
                else
                {
                    registerPasswordMessage.Text = Message.E100;
                }
            }
            else
            {
                registerEmailMessage.Text = Message.E100;
            }
        }

        private void clearRegisterMessages()
        {
            registerEmailMessage.Text = "";
            registerPasswordMessage.Text = "";
            registerConfirmPasswordMessage.Text = "";
        }
    }
}