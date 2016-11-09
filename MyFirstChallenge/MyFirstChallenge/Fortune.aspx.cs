using System;


namespace MyFirstChallenge
{
    public partial class Fortune : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       protected void fortuneButton_Click1(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            string pocketMoney = pocketTextBox.Text;

            string result = "At " + age + " years old, I cannot believe you only have $" + pocketMoney + " in your pocket!";

            fortuneLabel.Text = result;
        }
    }
}