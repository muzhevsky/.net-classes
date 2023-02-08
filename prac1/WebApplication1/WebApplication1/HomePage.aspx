<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <asp:Label ID="LoginLabel" runat="server" Text="Login"></asp:Label>
        <br />
        <asp:TextBox ID="LoginTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="PasswordTextBox" runat="server" Width="119px"></asp:TextBox>
        <br />
        <asp:Button ID="Submit" runat="server" OnClick="Button1_Click" Text="Login" />
        <p>
            <asp:Label ID="OutputLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
