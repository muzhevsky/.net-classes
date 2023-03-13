<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
                    <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
                </Columns>
            </asp:GridView>
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Добавить" />
            <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Изменить" />
            <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Удалить" />
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <asp:Label ID="Label1" runat="server" Text="Имя"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Фамилия"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Год"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" />
            </asp:Panel>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="Delete Customers where id=@id" InsertCommand="Insert into Customers(name,surname,year) values(@name,@surname,@year)" SelectCommand="SELECT * FROM [Customers]" UpdateCommand="update customers set name=@name, surname=@surname,year=@year where id=@id">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="name" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TextBox2" Name="surname" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TextBox3" Name="year" PropertyName="Text" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="name" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="GridView1" Name="surname" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="GridView1" Name="year" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                    <asp:BoundField DataField="customer_id" HeaderText="customer_id" SortExpression="customer_id" />
                </Columns>
            </asp:GridView>
            <asp:CheckBox ID="CheckBox4" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox4_CheckedChanged" Text="Добавить" Visible="False" />
            <asp:CheckBox ID="CheckBox5" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox5_CheckedChanged" Text="Изменить" Visible="False" />
            <asp:CheckBox ID="CheckBox6" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox6_CheckedChanged" Text="Удалить" Visible="False" />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" Visible="False">
                <asp:Label ID="Label4" runat="server" Text="Title"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="price"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Добавить" />
            </asp:Panel>
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            DeleteCommand="DELETE FROM [Order] where id=@id"
            InsertCommand="INSERT INTO [Order] ( title, price, customer_id) VALUES (@title,@price,@customer_id)"
            SelectCommand="SELECT * FROM [Order] WHERE ([customer_id] = @customer_id)"
            UpdateCommand="UPDATE [Order] SET title =@title, price =@price, customer_id = @customer_id  where id=@id">
            <DeleteParameters>
                <asp:ControlParameter ControlID="GridView2" Name="id" PropertyName="SelectedValue" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="TextBox4" Name="title" PropertyName="Text" />
                <asp:ControlParameter ControlID="TextBox5" Name="price" PropertyName="Text" />
                <asp:ControlParameter ControlID="GridView1" PropertyName="SelectedValue"  Name="customer_id"  />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="customer_id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="GridView2" Name="title" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="GridView2" Name="price" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="GridView2" PropertyName="SelectedValue" Name="customer_id"  />
                <asp:ControlParameter ControlID="GridView2" Name="id" PropertyName="SelectedValue" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
