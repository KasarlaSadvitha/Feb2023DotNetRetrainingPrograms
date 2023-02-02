<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="asp.netGlobalWebApplication.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 231px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="UserNameValidator" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUserName" ForeColor="#FF6600"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:CustomValidator ID="LengthValidator" runat="server" ErrorMessage="Length must be 6 characters minimum" OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="txtUserName"></asp:CustomValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="AgeValidator" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtAge" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RangeValidator ID="AgeRangeValidator1" runat="server" ErrorMessage="Age Should Be Between 18 to 50" ForeColor="Red" MaximumValue="50" MinimumValue="18" Type="Integer" ControlToValidate="txtAge"></asp:RangeValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator1" runat="server" ErrorMessage="Email Id Not In Corret Form" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="PWD"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ErrorMessage="Password Must Be Entered" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
