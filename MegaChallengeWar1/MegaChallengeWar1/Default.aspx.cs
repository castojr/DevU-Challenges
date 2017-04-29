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
               {14, new Card {CardNumber = 2, CardSuit = "Diamonds", CardName = "2 of Diamonds" }},
               {15, new Card {CardNumber = 3, CardSuit = "Diamonds", CardName = "3 of Diamonds" }},
               {16, new Card {CardNumber = 4, CardSuit = "Diamonds", CardName = "4 of Diamonds" }},
               {17, new Card {CardNumber = 5, CardSuit = "Diamonds", CardName = "5 of Diamonds" }},
               {18, new Card {CardNumber = 6, CardSuit = "Diamonds", CardName = "6 of Diamonds" }},
               {19, new Card {CardNumber = 7, CardSuit = "Diamonds", CardName = "7 of Diamonds" }},
               {20, new Card {CardNumber = 8, CardSuit = "Diamonds", CardName = "8 of Diamonds" }},
               {21, new Card {CardNumber = 9, CardSuit = "Diamonds", CardName = "9 of Diamonds" }},
               {22, new Card {CardNumber = 10, CardSuit = "Diamonds", CardName = "10 of Diamonds" }},
               {23, new Card {CardNumber = 11, CardSuit = "Diamonds", CardName = "Jack of Diamonds" }},
               {24, new Card {CardNumber = 12, CardSuit = "Diamonds", CardName = "Queen of Diamonds" }},
               {25, new Card {CardNumber = 13, CardSuit = "Diamonds", CardName = "King of Diamonds" }},
               {26, new Card {CardNumber = 14, CardSuit = "Diamonds", CardName = "Ace of Diamonds" }},
               {27, new Card {CardNumber = 2, CardSuit = "Clubs", CardName = "2 of Clubs" }},
               {28, new Card {CardNumber = 3, CardSuit = "Clubs", CardName = "3 of Clubs" }},
               {29, new Card {CardNumber = 4, CardSuit = "Clubs", CardName = "4 of Clubs" }},
               {30, new Card {CardNumber = 5, CardSuit = "Clubs", CardName = "5 of Clubs" }},
               {31, new Card {CardNumber = 6, CardSuit = "Clubs", CardName = "6 of Clubs" }},
               {32, new Card {CardNumber = 7, CardSuit = "Clubs", CardName = "7 of Clubs" }},
               {33, new Card {CardNumber = 8, CardSuit = "Clubs", CardName = "8 of Clubs" }},
               {34, new Card {CardNumber = 9, CardSuit = "Clubs", CardName = "9 of Clubs" }},
               {35, new Card {CardNumber = 10, CardSuit = "Clubs", CardName = "10 of Clubs" }},
               {36, new Card {CardNumber = 11, CardSuit = "Clubs", CardName = "Jack of Clubs" }},
               {37, new Card {CardNumber = 12, CardSuit = "Clubs", CardName = "Queen of Clubs" }},
               {38, new Card {CardNumber = 13, CardSuit = "Clubs", CardName = "King of Clubs" }},
               {39, new Card {CardNumber = 14, CardSuit = "Clubs", CardName = "Ace of Clubs" }},
               {40, new Card {CardNumber = 2, CardSuit = "Spades", CardName = "2 of Spades" }},
               {41, new Card {CardNumber = 3, CardSuit = "Spades", CardName = "3 of Spades" }},
               {42, new Card {CardNumber = 4, CardSuit = "Spades", CardName = "4 of Spades" }},
               {43, new Card {CardNumber = 5, CardSuit = "Spades", CardName = "5 of Spades" }},
               {44, new Card {CardNumber = 6, CardSuit = "Spades", CardName = "6 of Spades" }},
               {45, new Card {CardNumber = 7, CardSuit = "Spades", CardName = "7 of Spades" }},
               {46, new Card {CardNumber = 8, CardSuit = "Spades", CardName = "8 of Spades" }},
               {47, new Card {CardNumber = 9, CardSuit = "Spades", CardName = "9 of Spades" }},
               {48, new Card {CardNumber = 10, CardSuit = "Spades", CardName = "10 of Spades" }},
               {49, new Card {CardNumber = 11, CardSuit = "Spades", CardName = "Jack of Spades" }},
               {50, new Card {CardNumber = 12, CardSuit = "Spades", CardName = "Queen of Spades" }},
               {51, new Card {CardNumber = 13, CardSuit = "Spades", CardName = "King of Spades" }},
               {52, new Card {CardNumber = 14, CardSuit = "Spades", CardName = "Ace of Spades" }},


           };
            // Displays all the Card names
            foreach (var playerCard in Deck)
            {
                cardsDealtLabel.Text += String.Format("{0}</br>", playerCard.Value.CardName);
            }        


        }
    }
}