<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FormsApp.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forms Application</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 960px;margin-top: 5px;margin-left: auto;margin-right: auto;">
        <table style="width:100%;">
            <tr><td colspan="2"><h2>IBR WORLD</h2></td></tr>
            <tr>
                <td style="vertical-align:top">
                    <h4>FORMS</h4>
                    <p>Create Maintain your data with FORMS. This website will provide you to create forms. You can view your data from any
                    where. Create your own structure.</p>
                    <h4>DEMO</h4>
                    <div>
                        <%--<iframe title="YouTube video player" class="youtube-player" type="text/html" 
                            width="640" height="390" src="http://www.youtube.com/embed/2TLCrrpZ5uU"
                            frameborder="0" allowFullScreen></iframe>--%>
                    </div>
                </td>
                <td style="width:200px; vertical-align:top;">
                    <table>
                        <tr><td><h4>LOGIN</h4></td></tr>
                        <tr><td>Email</td></tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="loginEmailTextBox" Text="mclark@gmail.com" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr><td><asp:Label ID="loginEmailMessage" runat="server" ForeColor="Red" /></td></tr>
                        <tr><td>Password</td></tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="loginPasswordTextBox" Text="mclark" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr><td><asp:Label ID="loginPasswordMessage" runat="server" ForeColor="Red" /></td></tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="loginLinkButton" runat="server" Text="Login" 
                                    onclick="loginLinkButton_Click"/>
                            </td>
                        </tr>
                    </table>
                    <hr />
                    <table>
                        <tr><td><h4>REGISTRATION</h4></td></tr>
                        <tr><td>Email</td></tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="registerEmailTextBox" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr><td><asp:Label ID="registerEmailMessage" runat="server" ForeColor="Red" /></td></tr>
                        <tr><td>Password</td></tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="registerPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr><td><asp:Label ID="registerPasswordMessage" runat="server" ForeColor="Red" /></td></tr>
                        <tr><td>Confirm Password</td></tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="registerConfirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr><td><asp:Label ID="registerConfirmPasswordMessage" runat="server" ForeColor="Red" /></td></tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="registerLinkButton" runat="server" Text="Register" 
                                    onclick="registerLinkButton_Click"/>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
