<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="Customers" ID="CustomersLabel"></asp:Label>
        <asp:GridView ID="CustomersGridView" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataKeyNames="Id" OnSelectedIndexChanged="CustomersGridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
                <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
            </Columns>
        </asp:GridView>
        <asp:Label runat="server" Text="Orders" ID="OrdersLabel"></asp:Label>
        <asp:GridView runat="server" ID="OrdersGridView"></asp:GridView>
    </form>
</body>
</html>
