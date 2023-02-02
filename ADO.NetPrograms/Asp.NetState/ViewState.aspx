<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="Asp.NetState.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome To Energy Store</title>
</head>
<body>
    <form id="form1" runat="server">

    
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="btnClick" />
        </p>
    </form>
</body>
</html>
