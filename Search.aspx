<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Login1.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnGetAllProducts" runat="server" OnClick="btnGetAllProducts_Click" Text="Get All Product" />
        <asp:Button ID="logoutButton" Text="Logout" runat="server" OnClick="logoutEventMethod" />
        <p>Hello</p>
            <asp:Label ID="userLabel" Text="No User" runat="server" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetProductByName" runat="server" OnClick="btnGetProductByName_Click" Text="Search" />
        </p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="297px" Width="812px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </form>
</body>
</html>
