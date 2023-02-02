<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FormsAuthentication.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
