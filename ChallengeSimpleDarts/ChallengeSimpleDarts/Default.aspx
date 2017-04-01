<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
    
        <br />
        <br />
        Player 1:
        <asp:Label ID="playerOneLabel" runat="server"></asp:Label>
        <br />
        Player 2:
        <asp:Label ID="playerTwoLabel" runat="server"></asp:Label>
        <br />
        <br />
        Winner!:
        <asp:Label ID="winnerLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
