using System.Collections.Generic;
using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja Bryce= new Ninja();
            Buffet hometown= new Buffet();
            Bryce.Eat(hometown.Serve());
            Bryce.Eat(hometown.Serve());
            Bryce.Eat(hometown.Serve());
            Bryce.Eat(hometown.Serve());
            Bryce.Eat(hometown.Serve());
            

        }
    }
}
