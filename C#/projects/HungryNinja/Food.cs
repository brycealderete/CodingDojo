namespace HungryNinja
{
    public class Food
    {
    public string Name;
    public int Calories;
    // Foods can be Spicy and/or Sweet
    public bool IsSpicy; 
    public bool IsSweet; 

    public Food (){}

    public Food (string name,int calories,bool isSpicy,bool isSweet)
    {
        Name=name;
        Calories=calories;
        IsSpicy=isSpicy;
        IsSweet=isSweet;
    }
    
    }
}