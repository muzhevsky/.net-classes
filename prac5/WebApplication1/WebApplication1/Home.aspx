<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>
<%@ Register Src="~/Calculator.ascx" TagPrefix="uc" TagName="Calculator"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc:Calculator runat="server" ID="Calculator" />
            <br />
            <br />
            <asp:Button runat="server" Width="170px" Text="Result" ID="Button_Result" OnClick="ResultButton_Click"></asp:Button>
            <br />
            <asp:Label runat="server" ID="ResultLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
