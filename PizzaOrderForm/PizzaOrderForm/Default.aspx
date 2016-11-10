<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaOrderForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
        }
        .auto-style2 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="papaBobImage" runat="server" ImageUrl="PapaBob.png" />
        <h1 class="auto-style1">Papa Bob&#39;s Pizza and Software</h1>
    
    </div>
        <asp:RadioButton ID="babyBobRadioButton" runat="server" GroupName="PizzaSize" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="mamaBobRadioButton" runat="server" GroupName="PizzaSize" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="papaBobRadioButton" runat="server" GroupName="PizzaSize" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinCrustRadioButton" runat="server" GroupName="PizzaDough" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepDishRadioButton" runat="server" GroupName="PizzaDough" Text="Deep Dish ($2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni ($1.50)" />
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions ($.75)" />
        <br />
        <asp:CheckBox ID="greenPepeprsCheckBox" runat="server" Text="Green Peppers ($.50)" />
        <br />
        <asp:CheckBox ID="redPeppersCheckBox" runat="server" Text="Red Peppers ($.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies ($2.00)" />
        <br />
        <br />
        <h2 style="font-family: Arial, Helvetica, sans-serif">Papa Bob&#39;s <span class="auto-style2">Special Deal</span></h2>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers, and Anchovies OR Pepperoni, Red Peppers, and Onions to your pizza.
        </p>
        <p>
            <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        </p>
        <p>
            TOTAL:&nbsp; $<asp:Label ID="totalLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
