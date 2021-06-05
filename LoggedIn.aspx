<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoggedIn.aspx.cs" Inherits="Login1.LoggedIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logged In</title>
</head>
<body>
    <p>Logged In Page</p>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="logoutButton" Text="Logout" runat="server" OnClick="logoutEventMethod" />
            <p>Hello</p>
            <asp:Label ID="userLabel" Text="No User" runat="server" />
        </div>
    </form>
</body>
</html>
