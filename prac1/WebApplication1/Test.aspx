<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebApplication1.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:ListBox ID="SpecialtyListBox" runat="server">
                <asp:ListItem>ИФСТ</asp:ListItem>
                <asp:ListItem>ПИНФ</asp:ListItem>
                <asp:ListItem>ИВЧТ</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:DropDownList ID="LanguageDropDownList" runat="server">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>GoLang</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:RadioButton ID="FullTimeFormRadio" runat="server" Text="Очное" GroupName="educationForm" OnCheckedChanged="FullTimeFormRadio_CheckedChanged" />
            <br />
            <asp:RadioButton ID="DistanceLearning" runat="server" Text="Заочное" GroupName="educationForm" OnCheckedChanged="DistanceLearning_CheckedChanged" />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
