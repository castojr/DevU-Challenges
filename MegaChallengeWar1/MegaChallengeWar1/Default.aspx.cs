using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar1
{
    public partial class Default :System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Player player1 = new Player();
            Player player2 = new Player();
            Card card = new Card();

            Dictionary<int, Card> Deck = new Dictionary<int, Card>
           {
               {1, new Card {CardNumber = 2, CardSuit = "Hearts", CardName = "2 of Hearts" }},
               {2, new Card {CardNumber = 3, CardSuit = "Hearts", CardName = "3 of Hearts" }},
               {3, new Card {CardNumber = 4, CardSuit = "Hearts", CardName = "4 of Hearts" }},
               {4, new Card {CardNumber = 5, CardSuit = "Hearts", CardName = "5 of Hearts" }},
               {5, new Card {CardNumber = 6, CardSuit = "Hearts", CardName = "6 of Hearts" }},
               {6, new Card {CardNumber = 7, CardSuit = "Hearts", CardName = "7 of Hearts" }},
               {7, new Card {CardNumber = 8, CardSuit = "Hearts", CardName = "8 of Hearts" }},
               {8, new Card {CardNumber = 9, CardSuit = "Hearts", CardName = "9 of Hearts" }},
               {9, new Card {CardNumber = 10, CardSuit = "Hearts", CardName = "10 of Hearts" }},
               {10, new Card {CardNumber = 11, CardSuit = "Hearts", CardName = "Jack of Hearts" }},
               {11, new Card {CardNumber = 12, CardSuit = "Hearts", CardName = "Queen of Hearts" }},
               {12, new Card {CardNumber = 13, CardSuit = "Hearts", CardName = "King of Hearts" }},
               {13, new Card {CardNumber = 14, CardSuit = "Hearts", CardName = "Ace of Hearts" }},


           };

            


        }
    }
}