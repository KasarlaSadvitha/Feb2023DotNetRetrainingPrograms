<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WriteCookies.aspx.cs" Inherits="ASP.NETState22.WriteCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnRedirect" runat="server" Text="Button" OnClick="btnRedirect_Click" />
        <div>
        </div>
        <asp:Label ID="MYLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
