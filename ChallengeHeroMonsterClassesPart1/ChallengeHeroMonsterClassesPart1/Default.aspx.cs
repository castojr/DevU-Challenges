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
            Character hero = new Character();
            Character monster = new Character();

            hero.Name = "He-Man";
            hero.Health = 100;
            hero.DamageMaximum = 50;
            hero.AttackBonus = 50;

            monster.Name = "Skeletor";
            monster.Health = 100;
            monster.DamageMaximum = 50;
            monster.AttackBonus = 50;

            int heroAttack = hero.Attack();
            int monsterDefend = monster.Defend(heroAttack);

            resultLabel.Text = String.Format("{0} strikes and {1} has {2} health left", hero.Name, monster.Name, monsterDefend);
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

    }
}