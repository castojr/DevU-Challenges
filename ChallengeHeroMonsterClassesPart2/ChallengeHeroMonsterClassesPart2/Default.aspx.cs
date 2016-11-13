using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart2
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

            Stats(hero);
            Stats(monster);
        }
        private void Stats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - Damage Maximum: {2} - Attack Bonus: {3}</p>", character.Name, character.Health, character.DamageMaximum, character.AttackBonus);
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set;}
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(DamageMaximum);
            return damage;
        }
        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
}