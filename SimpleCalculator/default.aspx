<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SimpleCalculator._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Calculator</h1>
        <p class="auto-style1">
            First Value:<asp:TextBox ID="firstTextBox" runat="server" Height="16px" Width="198px"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Second Value:<asp:TextBox ID="secondTextBox" runat="server" Height="16px" Width="208px"></asp:TextBox>
        </p>
    
    </div>
        <asp:Button ID="plusButton" runat="server" OnClick="plusButton_Click" Text="+" Width="34px" />
&nbsp;
        <asp:Button ID="minusButton" runat="server" OnClick="minusButton_Click1" Text="-" Width="34px" />
&nbsp;
        <asp:Button ID="multiButton" runat="server" OnClick="multiButton_Click" Text="*" Width="34px" />
&nbsp;
        <asp:Button ID="divButton" runat="server" OnClick="divButton_Click" Text="/" Width="34px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" BackColor="#9966FF"></asp:Label>
    </form>
</body>
</html>
