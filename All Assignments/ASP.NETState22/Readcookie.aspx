<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Readcookie.aspx.cs" Inherits="ASP.NETState22.Readcookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="ButtonClick" />
        <br />
        <br />
        <asp:Label ID="lblTime" runat="server" Text="Time:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblCurrentTime" runat="server" Text="CurrentTime:"></asp:Label>
    </form>
</body>
</html>
