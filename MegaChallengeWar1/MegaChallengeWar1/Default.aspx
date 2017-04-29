<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeWar1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Play WAR: The Card Game of Chance!<br />
        <br />
        <asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="GO!" />
        <br />
        <br />
        <asp:Label ID="cardsDealtLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
