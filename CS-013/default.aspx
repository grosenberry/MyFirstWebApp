<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_011._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is<asp:TextBox ID="isTextBox" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="comparisonTypeLabel" runat="server"></asp:Label>
&nbsp;<asp:TextBox ID="equalToTextBox" runat="server"></asp:TextBox>
        ?<br />
        <br />
        <asp:CheckBox ID="oldCheckBox" runat="server" Text="I am checked" OnCheckedChanged="oldCheckBox_CheckedChanged" />
        <br />
    
    </div>
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
