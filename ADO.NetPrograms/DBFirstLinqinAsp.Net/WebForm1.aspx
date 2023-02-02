<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DBFirstLinqinAsp.Net.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 341px;
        }
    </style>
</head>
<body>
    <form id="lblEmployeeCount" runat="server">
        <div>
        </div>
        <asp:Button ID="btnShowDepartments" runat="server" Text="ShowDepartments" OnClick="btnShowDepartments_Click" />
        <asp:GridView ID="dgvDepartments" runat="server">
        </asp:GridView>
        <asp:Button ID="btnShowEmployees" runat="server" OnClick="btnShowEmployees_Click" Text="Show Employees" />
        <asp:GridView ID="dgvEmployees" runat="server">
        </asp:GridView>
        <br />
       <%--  <asp:Label ID="lblEmployeeCount" runat="server" Text="Label"></asp:Label>   --%>
        <br />
        <br />
        <asp:Label ID="lblSalary" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
