using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrderForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            totalLabel.Text = "";

            double babyBob = (babyBobRadioButton.Checked) ? 10.00 : 0.00;
            double mamaBob = (mamaBobRadioButton.Checked) ? 13.00 : 0.00;
            double papaBob = (papaBobRadioButton.Checked) ? 16.00 : 0.00;
            double deepDish = (deepDishRadioButton.Checked) ? 2.00 : 0.00;
            double pepperoni = (pepperoniCheckBox.Checked) ? 1.50 : 0.00;
            double onions = (onionsCheckBox.Checked) ? 0.75 : 0.00;
            double greenPeppers = (greenPepeprsCheckBox.Checked) ? 0.50 : 0.00;
            double redPeppers = (redPeppersCheckBox.Checked) ? 0.75 : 0.00;
            double anchovies = (anchoviesCheckBox.Checked) ? 2.00 : 0.00;


            if ((pepperoniCheckBox.Checked && greenPepeprsCheckBox.Checked && anchoviesCheckBox.Checked) || (pepperoniCheckBox.Checked && redPeppersCheckBox.Checked && onionsCheckBox.Checked))
            {
                totalLabel.Text = (babyBob + mamaBob + papaBob + deepDish + pepperoni + onions + greenPeppers + redPeppers + anchovies - 2.00).ToString();
            } 
            else
            {
                totalLabel.Text = (babyBob + mamaBob + papaBob + deepDish + pepperoni + onions + greenPeppers + redPeppers + anchovies).ToString();
            }
            


        }
    }
}