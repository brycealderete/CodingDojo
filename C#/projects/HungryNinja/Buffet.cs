using System;
using System.Collections.Generic;
namespace HungryNinja
{
    public class Buffet
    {
        public List<Food> Menu;
    
        //constructor
        public Buffet()
        {
        Menu = new List<Food>()
        {
            new Food("Noodles", 400, false, false),
            new Food("Prime Rib", 200, false, false),
            new Food("Mashed Patatoes", 500, false, false),
            new Food("Honey Baked Ham", 600, false, true),
            new Food("Rice", 300, false, false),
            new Food("Speghetti", 500, true, false),
            new Food("Meatballs", 300, true, false)
        };
        }
    public Food Serve()
    {
        Random rand= new Random();
        rand.Next(Menu.Count +1);
        return Menu[rand.Next(Menu.Count)];
    }
    }
}