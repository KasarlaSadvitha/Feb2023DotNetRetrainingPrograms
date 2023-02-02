<%@ Page Language="C#" AutoEventWireup="true" EnableViewState="true" CodeBehind="MyState.aspx.cs" Inherits="ASP.NETState22.MyState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 186px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" EnableViewState="true" ></asp:ListBox>
        <asp:Button ID="Button1" runat="server" Height="24px" Text="Button" OnClick="btnClick" />
    </form>
</body>
</html>
