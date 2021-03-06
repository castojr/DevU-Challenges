﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SlotMachineChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="randomImageOne" runat="server" Height="300px" Width="275px" OnDataBinding="Page_Load" />
        <asp:Image ID="randomImageTwo" runat="server" Height="300px" Width="275px" OnDataBinding="Page_Load" />
        <asp:Image ID="randomImageThree" runat="server" Height="300px" Width="275px" OnDataBinding="Page_Load" />
        <br />
        <br />
        Your Bet
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull The Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server" OnDataBinding="Page_Load" ViewStateMode="Enabled"></asp:Label>
        <br />
        <br />
        1 Cherry - x2 Your Bet<br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your bet<br />
        HOWEVER...if there&#39;s even one bar you win nothing!</div>
    </form>
</body>
</html>
