using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Bryce= new Wizard("Bryce");
            Console.WriteLine(Bryce.health);
            Samurai Attacker= new Samurai ("Attacker");
            Console.WriteLine(Attacker.Attack(Bryce));
            Console.WriteLine(Bryce.health);

            // Person greg= new Person("Greg");
            // Console.WriteLine(greg.Attack(Bryce));

        }
    }
}
