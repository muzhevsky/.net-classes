<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="prac2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="Login" ID="LoginLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="LoginTextBox"></asp:TextBox><asp:Label runat="server" ID="InvalidLoginLabel"></asp:Label><br />

        <asp:Label runat="server" Text="Password" ID="PasswordLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="PasswordTextBox"></asp:TextBox><asp:Label runat="server" ID="InvalidPasswordLabel"></asp:Label><br />

        <asp:Label runat="server" Text="Confirm Password" ID="ConfirmPasswordLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="ConfirmPasswordTextBox"></asp:TextBox><asp:Label runat="server" ID="InvalidConfirmPasswordLabel"></asp:Label><br />

        <asp:Label runat="server" Text="E-mail" ID="EmailLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="EmailTextBox"></asp:TextBox><asp:Label runat="server" ID="InvalidEmailLabel"></asp:Label><br />

        <asp:Label runat="server" Text="Age" ID="AgeLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="AgeTextBox"></asp:TextBox><asp:Label runat="server" ID="InvalidAgeLabel"></asp:Label><br />

        <asp:Button runat="server" Text="Sign Up" ID="Submit" OnClick="OnSubmitButtonPress"></asp:Button>
    </form>
</body>
</html>
