﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="FormsApp.home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="float:left;">
            Welcome 
            <asp:Label ID="welcomeLabel" runat="server"/>
        </div>
        <div style="float:right;">
            <asp:LinkButton ID="signoutLinkButton" runat="server" 
                onclick="signoutLinkButton_Click">Signout</asp:LinkButton>
        </div>
    </div>
    <div></div>
    </form>
</body>
</html>
