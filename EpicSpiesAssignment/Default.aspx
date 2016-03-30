<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
            height: 235px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img class="auto-style1" src="epic-spies-logo.jpg" /></div>
        <p>
            Spy Code Name:
            <asp:TextBox ID="spyNameBox" runat="server"> </asp:TextBox>
&nbsp;&nbsp;
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignNameBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:<asp:Calendar ID="endDateCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:<asp:Calendar ID="startDateCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:<asp:Calendar ID="projEndDateCalendar" runat="server"></asp:Calendar>
        </p>
        <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
