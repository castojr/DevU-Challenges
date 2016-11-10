using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Phoenix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Phoenix", "Cyclops", "Wolernine", "NightClawer", "Superman", "Batman" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";
            int mostBattles = 0;
            int fewestBattles = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[mostBattles])
                {
                    mostBattles = i;
                }
                if (numbers[i] < numbers[fewestBattles])
                {
                    fewestBattles = i;
                }
            }
            result = String.Format("Most battles was {0} with {1} battles <br/> Fewest battles was {2} with {3} battles", names[mostBattles], numbers[mostBattles], names[fewestBattles], numbers[fewestBattles]);
            resultLabel.Text = result;
        }
    }
}