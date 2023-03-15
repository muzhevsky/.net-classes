<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calculator.ascx.cs" Inherits="WebApplication1.Calculator" %>
<asp:TextBox runat="server" ID="Calculator_TB"></asp:TextBox>
<br />
<asp:Button runat="server" Width="40px" Text="1" ID="Button_1" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="2" ID="Button_2" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="3" ID="Button_3" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="+" ID="Button_sum" OnClick="CommonButton_Click"></asp:Button>
<br />
<asp:Button runat="server" Width="40px" Text="4" ID="Button_4" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="5" ID="Button_5" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="6" ID="Button_6" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="-" ID="SubstractButton" OnClick="CommonButton_Click"></asp:Button>
<br />
<asp:Button runat="server" Width="40px" Text="7" ID="Button_7" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="8" ID="Button_8" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="9" ID="Button_9" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="*" ID="MultiplyButton" OnClick="CommonButton_Click"></asp:Button>
<br />
<asp:Button runat="server" Width="40px" Text="c" ID="ClearButton" OnClick="ClearButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="0" ID="Button_0" OnClick="CommonButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="b" ID="BackspaceButton" OnClick="BackspaceButton_Click"></asp:Button>
<asp:Button runat="server" Width="40px" Text="/" ID="DivideButton" OnClick="CommonButton_Click"></asp:Button>
<br />
