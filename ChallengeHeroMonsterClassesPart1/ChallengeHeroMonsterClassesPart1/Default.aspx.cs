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
            hero.AttackBonus = true;

            monster.Name = "Skeletor";
            monster.Health = 100;
            monster.DamageMaximum = 50;
            monster.AttackBonus = true;

            int heroAttack = hero.Attack(); 
            monster.Defend(heroAttack);

            int monsterAttack = monster.Attack();
            hero.Defend(monsterAttack);

            resultLabel.Text = String.Format("<h1>ROUND 1</h1>{0}'s Health = {1}%<br/>{2}'s Health = {3}%", hero.Name, heroDefend, monster.Name, monsterDefend);
        }

        
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        
        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(DamageMaximum);
            return damage;
        }

        public void Defend (int damage)
        {
            this.Health -= damage;
             

        }

    }
}