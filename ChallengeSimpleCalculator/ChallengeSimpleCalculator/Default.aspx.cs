using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            string value1 = firstValueTextBox.Text;
            string value2 = secondValueTextBox.Text;

            int result = Convert.ToInt32(value1) + Convert.ToInt32(value2);

            resultLabel.Text = result.ToString();
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            string value1 = firstValueTextBox.Text;
            string value2 = secondValueTextBox.Text;

            int result = Convert.ToInt32(value1) - Convert.ToInt32(value2);

            resultLabel.Text = result.ToString();
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            string value1 = firstValueTextBox.Text;
            string value2 = secondValueTextBox.Text;

            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);

            resultLabel.Text = result.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            string value1 = firstValueTextBox.Text;
            string value2 = secondValueTextBox.Text;

            decimal result = Convert.ToDecimal(value1) / Convert.ToDecimal(value2);

            resultLabel.Text = result.ToString();
        }
    }
}