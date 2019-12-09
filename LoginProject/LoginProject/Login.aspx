<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <asp:Image ID="Image1" ImageUrl="~/fram.png" runat="server" />
    </div>
        <div class="content">
            <h2>SIGN IN</h2>
            <asp:TextBox ID="txtusername" runat="server" placeholder="Username"></asp:TextBox>
            <asp:TextBox ID="pw2" TextMode="Password" runat="server" />
            <asp:Button ID="btnlogin" runat="server" Text="LOGIN" OnClick="btnlogin_Click1" />
        </div>
    </form>
</body>
</html>
