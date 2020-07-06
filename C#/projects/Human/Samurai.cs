using System;

namespace Human
{
    public class Samurai : Person
    {
        public Samurai(string name): base(name)
        {
            health=200;
        }
        public override int Attack(Person target)
        {
            base.Attack(target);
            Console.WriteLine(target.health);
            if (target.health<50)
            {
                target.health=0;
                Console.WriteLine($"{target.Name} has died!");
            }
            return target.health;

        }
    }
}