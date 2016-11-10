<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="191px" ImageUrl="epic-spies-logo.jpg" Width="153px" />
        <h1 class="auto-style1"><strong>Asset Performance Tracker</strong></h1>
        <br />
        <br />
        Asset Name:&nbsp; <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged:&nbsp;
        <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of Subterfuged Performed:&nbsp;
        <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addAssetButton" runat="server" OnClick="addAssetButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
