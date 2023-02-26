<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="prac2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="Login" ID="LoginLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="LoginTextBox"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Login field can't be empty" ControlToValidate="LoginTextBox"></asp:RequiredFieldValidator><br />

        <asp:Label runat="server" Text="Password" ID="PasswordLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="PasswordTextBox" CausesValidation="True"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Enter password" ControlToValidate="PasswordTextBOx"></asp:RequiredFieldValidator><asp:RegularExpressionValidator runat="server" ErrorMessage="Password should consist of 8 or more characters" ControlToValidate="PasswordTextBox" ValidationExpression="\w{8,}"></asp:RegularExpressionValidator><br />

        <asp:Label runat="server" Text="Confirm Password" ID="ConfirmPasswordLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="ConfirmPasswordTextBox" CausesValidation="True"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Enter password confirmation" ControlToValidate="ConfirmPasswordTextBox"></asp:RequiredFieldValidator><asp:CompareValidator runat="server" ErrorMessage="Doesn't match with password field" ControlToValidate="ConfirmPasswordTextBox" ControlToCompare="PasswordTextBox"></asp:CompareValidator><br />

        <asp:Label runat="server" Text="E-mail" ID="EmailLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="EmailTextBox"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Email is empty" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator><asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="EmailTextBox"></asp:RegularExpressionValidator><br />

        <asp:Label runat="server" Text="Age" ID="AgeLabel"></asp:Label><br />
        <asp:TextBox runat="server" ID="AgeTextBox"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Age is empty" ControlToValidate="AgeTextBox"></asp:RequiredFieldValidator><asp:RangeValidator runat="server" ErrorMessage="Invalid age" MinimumValue="18" ControlToValidate="AgeTextBox" MaximumValue="65"></asp:RangeValidator><br />

        <asp:Button runat="server" Text="Sign Up" ID="Submit" OnClick="OnSubmitButtonPress"></asp:Button>
    </form>
</body>
</html>
