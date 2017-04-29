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

           Dictionary<int, Card> CardSuits = new Dictionary<int, Card>
           {
               {1, new Card {CardNumber = 1 } }
           }

            


        }
    }
}