using System;
using System.Web.UI;


namespace SlotMachineChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!Page.IsPostBack)
            {
                randomImageOne.ImageUrl = ImageGenerator();
                randomImageTwo.ImageUrl = ImageGenerator();
                randomImageThree.ImageUrl = ImageGenerator();
                int winnings = 100;
                ViewState.Add("Money", winnings);
                PlayersMoneyDisplay();
            }                      
        }

        Random random = new Random();

        private string ImageGenerator()
        {
            string[] png = new string[] {"Bar.png", "Bell.png", "Cherry.png", "Clover.png", "Diamond.png", "HorseShoe.png", "Lemon.png", "Orange.png", "Plum.png", "Seven.png", "Strawberry.png", "Watermellon.png"};
            return png[random.Next(png.Length)];
        }
 
        private string RandomImageGenerator()
        {
            randomImageOne.ImageUrl = ImageGenerator();
            randomImageTwo.ImageUrl = ImageGenerator();
            randomImageThree.ImageUrl = ImageGenerator();
            return ImageGenerator();             
        }

        private int YourBet()
        {
            return int.Parse(betTextBox.Text);
        }

        private bool ThreeSevens()
        {
            if (randomImageOne.ImageUrl == "Seven.png" && randomImageTwo.ImageUrl == "Seven.png" && randomImageThree.ImageUrl == "Seven.png")
            {
                return true;
            }
            return false;
        }

        private string ThreeSevensResult()
        {
            return resultLabel.Text = String.Format("JACKPOT!!! You bet {0:C} and Won {1:C}", YourBet(), YourBet() * 100);
        }

        private bool Bar()
        {
            if (randomImageOne.ImageUrl == "Bar.png" || randomImageTwo.ImageUrl == "Bar.png" || randomImageThree.ImageUrl == "Bar.png")
            {
                return true;
            }
            return false;
        }

        private string BarResult()
        {
            return resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", YourBet());
        }

        private bool ThreeCherry()
        {
            if (randomImageOne.ImageUrl == "Cherry.png" && randomImageTwo.ImageUrl == "Cherry.png" && randomImageThree.ImageUrl == "Cherry.png")
            {
                return true;
            }
            return false;
        }

        private string ThreeCherryResult()
        {
            return resultLabel.Text = String.Format("You bet {0:C} and Won {1:C}", YourBet(), YourBet() * 4);
        }

        private bool OneCherry()
        {
            if (randomImageOne.ImageUrl == "Cherry.png" || randomImageTwo.ImageUrl == "Cherry.png" || randomImageThree.ImageUrl == "Cherry.png")
            {
                return true;
            }
            return false;
        }

        private string OneCherryResult()
        {
            return resultLabel.Text = String.Format("You bet {0:C} and Won {1:C}", YourBet(), YourBet() * 2);
        }

        private bool TwoCherry()
        {
            if (randomImageOne.ImageUrl == "Cherry.png" && randomImageTwo.ImageUrl == "Cherry.png")
            {
                return true;
            }
            else if (randomImageTwo.ImageUrl == "Cherry.png" && randomImageThree.ImageUrl == "Cherry.png")
            {
                return true;
            }
            else if (randomImageOne.ImageUrl == "Cherry.png" && randomImageThree.ImageUrl == "Cherry.png")
            {
                return true;
            }

                return false;
        }

        private string TwoCherryResult()
        {
            return resultLabel.Text = String.Format("You bet {0:C} and Won {1:C}", YourBet(), YourBet() * 3);
        }

        private string YouLoseText()
        {
            return resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", YourBet());
        }

        private string PullLeverResults()
        {
            if (ThreeSevens())
            {
                return ThreeSevensResult();
            }
            else if (Bar())
            {
                return BarResult();
            }
            else if (ThreeCherry())
            {
                return ThreeCherryResult();
            }
            else if (TwoCherry())
            {
                return TwoCherryResult();
            }
            else if (OneCherry())
            {
                return OneCherryResult();
            }
            else
            {
                return YouLoseText();
            }
        }
        
        private int WinLose()
        {
            if(PullLeverResults()  == String.Format("Sorry, you lost {0:C}. Better luck next time.", YourBet()))
            {
                return -YourBet();
            }
            return YourBet();
        }

        private string PlayersMoneyDisplay()
        {
            return moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["Money"]);      
        }

        private void UpdatedWinnings()
        {
            int winnings = (int)ViewState["Money"];
            winnings += WinLose();
            ViewState["Money"] = winnings;
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if(betTextBox.Text.Trim().Length == 0)
            {
                return;
            }

            if (!int.TryParse(betTextBox.Text, out bet))
            {
                return;
            }

            RandomImageGenerator();      
            PullLeverResults();
            UpdatedWinnings();
            PlayersMoneyDisplay();   
        }
    }
}