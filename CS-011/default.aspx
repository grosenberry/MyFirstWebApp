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
&nbsp;equal to
        <asp:TextBox ID="equalToTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
        <br />
        <br />
        If you only could choose one food to eat the rest of your life which would you pick?<br />
        <asp:RadioButton ID="pizzaRadioButton" runat="server" GroupName="FoodGroup" Text="Pizza" />
        <br />
        <asp:RadioButton ID="saladRadioButton" runat="server" GroupName="FoodGroup" Text="Salad" />
        <br />
        <asp:RadioButton ID="pbjRadioButton" runat="server" GroupName="FoodGroup" Text="Peanut Butter and Jelly" />
    
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
