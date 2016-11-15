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
            Random random = new Random();
            Dice redDice = new Dice();
            
            Character hero = new Character();
            hero.Name = "He-Man";
            hero.Health = 100;
            hero.DamageMaximum = 6;
            hero.AttackBonus = true;

            Character monster = new Character();
            monster.Name = "Skeletor";
            monster.Health = 100;
            monster.DamageMaximum = 6;
            monster.AttackBonus = true;

            int heroAttack = hero.Attack(redDice);
            monster.Defend(heroAttack);
            if (hero.AttackBonus)
            {
                monster.Health -= monster.DamageMaximum;
            }
            

            int monsterAttack = monster.Attack(redDice);
            hero.Defend(monsterAttack);
            if (monster.AttackBonus)
            {
                hero.Health -= hero.DamageMaximum;
            }

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

        public int Attack(Dice dice)
        {
            dice.Sides = DamageMaximum;
            return dice.Roll();
        }
        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
    
    class Dice
    {
        Random random = new Random();
        public int Sides { get; set; }

        public int Roll()
        {
            return random.Next(this.Sides);
        }
    }
}