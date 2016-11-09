using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "You selected a pencil";
                assetImage.ImageUrl = "pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "You selected a pen";
                assetImage.ImageUrl = "pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "You selected an iPhone 7";
                assetImage.ImageUrl = "phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = " Buy a Surface Book";
                assetImage.ImageUrl = "tablet.png";
            }
            else
            {
                resultLabel.Text = "PLEASE CHOOSE A TOOL!";
            }
        }
    }
}