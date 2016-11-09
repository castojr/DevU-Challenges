<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
        }
        .auto-style2 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <h1 class="auto-style1"><strong>Simple Calculator</strong></h1>
        <h3><span class="auto-style2">First Value:</span>&nbsp;
            <asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
        </h3>
        <p>
            <asp:Button ID="additionButton" runat="server" OnClick="additionButton_Click" Text="+" />
&nbsp;
            <asp:Button ID="subtractionButton" runat="server" Text="-" OnClick="subtractionButton_Click" />
&nbsp;
            <asp:Button ID="multiplicationButton" runat="server" Text="*" OnClick="multiplicationButton_Click" />
&nbsp;
            <asp:Button ID="divisionButton" runat="server" Text="/" OnClick="divisionButton_Click" />
        </p>
        <h3><strong>Second Value:&nbsp; </strong>
            <asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
        </h3>
        <p>
            &nbsp;</p>
        <h1>
            <asp:Label ID="resultLabel" runat="server" BackColor="#0099FF"></asp:Label>
        </h1>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
