<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerSideWebForm.aspx.cs" Inherits="asp.netGlobalWebApplication.ServerSideWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 221px">
            <br />
            <asp:Label ID="lblSession" runat="server" Text="Session"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSession" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblApplicaiton" runat="server" Text="Application"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtApplication" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnPrintHello" runat="server" Text="PrintHello" OnClick="btnHello" />
            <br />
            <br />
            <asp:Label ID="lblSessionCount" runat="server" Text="Session Count"></asp:Label>
        </div>
    </form>
</body>
</html>
