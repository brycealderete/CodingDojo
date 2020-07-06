using System;

namespace Human
{
    public class Wizard : Person
    {
        public Wizard(string name) : base(name)
        {
            Intelligence=25;
            health=50;
        }
        public override int Attack(Person target)
        {
            var dmg = this.Intelligence *5;
            var myhealth=target.health;
            myhealth-=dmg ;
            this.health+=dmg;
            
            return myhealth;
        }
    }
}