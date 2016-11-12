using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }

        Random random = new Random();
        public int Attack()
        {
            int damageInflicted = random.Next();
            return damageInflicted;
        }

        public int Defend (int damage)
        {
            int defendFromAttack = this.Health - damage;
            return defendFromAttack; 

        }

        /*
        The Character class should have two methods:
        2. Defend(int damage) - deducts the damage from this Character's health
        */
    }
}