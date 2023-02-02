<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CrudOperationsConectedDisconnectedin_ASP.NetWeb_App.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="EmpID"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" style="margin-left: 32px" Width="171px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="margin-left: 34px" Width="171px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Salary"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server" style="margin-left: 36px" Width="159px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="DeptID"></asp:Label>
            <asp:TextBox ID="txtdid" runat="server" style="margin-left: 38px" Width="148px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSelect" runat="server" Text="Select"  OnClick="btnSelect_Click"/>
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"/>
            <asp:Button ID="btnUpdate" runat="server" Text="Update" Onclick="btnUpdate_Click"/>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnnDelete_Click" />
        </p>
        <asp:GridView ID="dgvEmployees" runat="server">
        </asp:GridView>
        <asp:Label ID="mylblinsert" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
