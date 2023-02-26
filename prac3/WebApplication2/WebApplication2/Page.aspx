<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page.aspx.cs" Inherits="WebApplication2.Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" DataSourceID="CustomersSource" AutoGenerateColumns="False" ID="CustomersGridView" DataKeyNames="id" AutoGenerateSelectButton="True" AutoGenerateEditButton="True">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" InsertVisible="False" SortExpression="id"></asp:BoundField>
                    <asp:BoundField DataField="surname" HeaderText="surname" SortExpression="surname"></asp:BoundField>
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name"></asp:BoundField>
                    <asp:BoundField DataField="age" HeaderText="age" SortExpression="age"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [customers]" ID="CustomersSource" UpdateCommand="update customers set name = @name, surname = @surname, @age = age where id = @id">
                <UpdateParameters>
                    <asp:ControlParameter ControlID="CustomersGridView" PropertyName="SelectedValue" Name="name"></asp:ControlParameter>
                    <asp:ControlParameter ControlID="CustomersGridView" PropertyName="SelectedValue" Name="surname"></asp:ControlParameter>
                    <asp:ControlParameter ControlID="CustomersGridView" PropertyName="SelectedValue" Name="age"></asp:ControlParameter>
                <asp:ControlParameter ControlID="CustomersGridView" PropertyName="SelectedValue" Name="id"></asp:ControlParameter></UpdateParameters>
            </asp:SqlDataSource>


            <asp:GridView runat="server" ID="GoodsGridView" DataSourceID="GoodsDataSource" AutoGenerateColumns="False" DataKeyNames="id">
                <Columns>
                    <asp:CommandField ShowSelectButton="True"></asp:CommandField><asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" InsertVisible="False" SortExpression="id"></asp:BoundField>
                    <asp:BoundField DataField="title" HeaderText="title" SortExpression="title"></asp:BoundField>
                    <asp:BoundField DataField="price_" HeaderText="price_" SortExpression="price_"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="GoodsDataSource" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [id], [title], [price ] AS price_ FROM [goods] WHERE ([customerId] = @customerId)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="CustomersGridView" PropertyName="SelectedValue" Name="customerId" Type="Int32"></asp:ControlParameter>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
