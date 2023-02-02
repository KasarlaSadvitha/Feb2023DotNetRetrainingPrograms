<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontPageForm.aspx.cs" Inherits="FrontFormAuthentication.FrontPageForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Front Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcone ABC Educational Organization
            To Access our page u need ot V<span lang="en-us">A</span>Rify ur Credintials
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click To Go Inside" />
    </form>
</body>
</html>
