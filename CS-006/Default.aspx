<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            background-color: #FFFFCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Heading 1</h1>
        <h2>Heading 2</h2>
        <h3>Heading 3</h3>
        <h4>Heading 4</h4>
        <h5>Heading 5</h5>
        <h6>Heading 6</h6>
        <p>
            <span class="newStyle1">This is some text I want to apply style to.</span></p>
        <p>
            <a href="http://www.learnvisualstudio.net">Add a hyperlink</a></p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.microsoft.com" Target="_blank">This is another hyperlink</asp:HyperLink>
        </p>
        <p>
            <asp:Image ID="Image1" runat="server" Height="71px" ImageUrl="~/Print.jpg" Width="116px" />
        </p>
        <table class="auto-style1">
            <tr>
                <td>Player</td>
                <td>Year</td>
                <td>Home Runs</td>
            </tr>
            <tr>
                <td class="auto-style2">Sammy Sosa</td>
                <td class="auto-style2">2005</td>
                <td class="auto-style2">100</td>
            </tr>
            <tr>
                <td>Mark McGuire</td>
                <td>2005</td>
                <td>200</td>
            </tr>
        </table>
    </form>
    <ol>
        <li>First Item</li>
        <li>Second Item</li>
        <li>Third Item</li>
    </ol>
    <ul>
        <li class="auto-style3">This is an idea</li>
        <li class="auto-style3">This is an equally good idea</li>
        <li class="auto-style3">This is another idea to consider</li>
    </ul>
    <p>
        &nbsp;</p>
</body>
</html>
