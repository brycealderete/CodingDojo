using System;
using System.Collections.Generic;
namespace HungryNinja
{
    public class Ninja
    {
        private int calorieIntake;
        public bool IsFull
        {
            get{
                if (calorieIntake>1200)
                return true;
                else return false;
            }
        }
    public List<Food> FoodHistory;
    public Ninja()
    {
        calorieIntake=0;
    }

    
    
    // add a public "getter" property called "IsFull"
    
    // build out the Eat method
    public void Eat(Food item)
    {
        
        if (IsFull==true)
        {
            Console.WriteLine("Ninja is full!");
        }
        if (IsFull==false)
        {
        calorieIntake+=item.Calories;
        if (item.IsSweet==true)
        {
            Console.WriteLine($"You ate {item.Name} it is sweet but not spicy");
        }
        else if (item.IsSpicy==true)
        {
            Console.WriteLine($"You ate {item.Name} it is spicy but not sweet");
        }
        else if (item.IsSweet && item.IsSpicy==true)
        {
            Console.WriteLine($"You ate {item.Name} it is sweet and spicy");
        }
        else Console.WriteLine($"You ate {item.Name} it is not sweet or spicy");
        }
        
    }
    }
}