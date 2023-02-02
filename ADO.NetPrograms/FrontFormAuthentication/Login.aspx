<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FrontFormAuthentication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 210px">
            <asp:Label ID="Label1" runat="server" Text="UserName">

            </asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtUserName" runat="server"> </asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password">

                        </asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />

            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Button1_Click" /></div>
    </form>
</body>
</html>
