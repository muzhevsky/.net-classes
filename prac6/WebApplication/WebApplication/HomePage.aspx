<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:label runat="server" Text="Введите число:" ID="Label"></asp:label>
            <br />
            <asp:TextBox runat="server" ID="NumberTextBox"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="ConfirmButton" OnClick="ConfirmButton_Click" Text="Квадрат числа"></asp:Button>
            <br />
            <asp:label runat="server" Text="Квадрат:" ID="ResultLabel"></asp:label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button runat="server" ID="RedirectButton" OnClick="RedirectButton_Click" Text="Перейти"/>
            <br />
            <br />
            <asp:Button runat="server" ID="GetDataButton" OnClick="GetDataButton_Click" Text="Загрузить данные"/>
            <br />
            <br />
            <asp:GridView runat="server" ID="GridView"></asp:GridView>
        </div>
    </form>
</body>
</html>
