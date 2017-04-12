<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeStudentCourses.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="assignmentOneButton" runat="server" OnClick="assignmentOneButton_Click" Text="Assignment 1" />
        <br />
        <br />
        <asp:Button ID="assignmentTwoButton" runat="server" OnClick="assignmentTwoButton_Click" Text="Assignment 2" />
        <br />
        <br />
        <asp:Button ID="assignmentThreeButton" runat="server" OnClick="assignmentThreeButton_Click" Text="Assignment 3" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
