using System;

namespace Human
{
    public class Ninja : Person
    {
        public Ninja (string name): base(name)
        {
            Dexterity=175;
        }
        public override int Attack(Person target)
        {
            int dmg = this.Dexterity *5;
            int myhealth=target.health;
            myhealth-=dmg;
            Random rand= new Random();
            int num=rand.Next(1,10);
            if (num==1)
            {
                myhealth-=10;
                Console.WriteLine("Extra 10 Damage taken");
            }
            else if (num==2)
            {
                myhealth-=10;
                Console.WriteLine("Extra 10 Damage taken");
            }
            
            
            return myhealth;
        }
    }
}