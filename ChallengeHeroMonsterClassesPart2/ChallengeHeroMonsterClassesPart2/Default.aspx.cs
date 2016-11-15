using System;


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
            

            while (hero.Health > 0 && monster.Health > 0)
            {
                int monsterAttack = monster.Attack(redDice);
                hero.Defend(monsterAttack);
                if (monster.AttackBonus)
                {
                    hero.Health -= hero.DamageMaximum;
                }
                
                int heroAttack = hero.Attack(redDice);
                monster.Defend(heroAttack);
                if (hero.AttackBonus)
                {
                    monster.Health -= monster.DamageMaximum;
                }
                if (hero.Health == 0 || monster.Health == 0)
                {                
                    break;
                }
                        
            }
            
            Stats(hero);
            Stats(monster);
            displayResult(hero, monster);
        }
        private void Stats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - Damage Maximum: {2} - Attack Bonus: {3}</p>", character.Name, character.Health, character.DamageMaximum, character.AttackBonus);
        }

        private void displayResult(Character opponent1, Character opponent2)
        {

            if (opponent1.Health < 0 && opponent2.Health < 0)
            {
                resultLabel.Text += String.Format("Both {0} and {1} died", opponent1.Name, opponent2.Name);
            }
            else if (opponent1.Health > opponent2.Health)
            {
                resultLabel.Text += String.Format("{0} Defeats {1}", opponent1.Name, opponent2.Name);
            }
            else if (opponent1.Health < opponent2.Health)
            {
                resultLabel.Text += String.Format("{0} Defeats {1}", opponent2.Name, opponent1.Name);
            }

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