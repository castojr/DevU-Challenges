using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConversionChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Converts width string to a double
        private double GetWidthInformation()
        {
            if(widthTextBox.Text.Trim().Length == 0)
            {
                return 0.0;
            }
                
            double width = 0.0;
            if (!Double.TryParse(widthTextBox.Text, out width))
            {
                return 0.0;
            }
                
            string getWidth = widthTextBox.Text;
            width = double.Parse(getWidth);
            return width;
        }       
       //Converts height string to a double
        private double GetHeightInformation()
        {
            if(heightTextBox.Text.Trim().Length == 0)
            {
                return 0.0;
            }

            double height = 0.0;
            if(!Double.TryParse(heightTextBox.Text, out height))
            {
                return 0.0;
            }
            string getHeight = heightTextBox.Text;
            height = double.Parse(getHeight);
            return height;
        }
        //Converts height string to a double
        private double GetLengthInformation()
        {
            if(lengthTextBox.Text.Trim().Length == 0)
            {
                return 0.0;
            }

            double length = 0.0;
            if(!Double.TryParse(lengthTextBox.Text, out length))
            {
                return 0.0;
            }

            string getLength = lengthTextBox.Text;
            length = double.Parse(getLength);
            return length;
        }

        private string CalculateShippingCost(double shippingCost)
        {
            if(GetWidthInformation() == 0.0)
            {
                return resultLabel.Text = String.Format("Please enter a numeric value in the width box");
            }
            else if (GetHeightInformation() == 0.0)
            {
                return resultLabel.Text = String.Format("Please enter a numeric value in the height box");
            }
                        else if (GetLengthInformation() > 0)
            {
                double cost = (GetWidthInformation() * GetHeightInformation() * GetLengthInformation()) * shippingCost;
                return resultLabel.Text = String.Format("The cost of the parcel is {0:C}", cost);
            }
            else
            {
                double cost = (GetWidthInformation() * GetHeightInformation()) * shippingCost;
                return resultLabel.Text = String.Format("The cost of the parcel is {0:C}", cost);
            }
            
        } 

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateShippingCost(.15);
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateShippingCost(.25);
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateShippingCost(.45);
        }
    }
}