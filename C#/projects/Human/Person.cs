namespace Human
{
    public class Person
    {
        public string Name {get; set;}
        public int Strength {get; set;}
        public int Intelligence {get; set;}
        public int Dexterity {get; set;}
        public int health {get; set;}
        
        public Person(){}
        public Person(string name)
        {
            Name=name;
            Strength=3;
            Intelligence=3;
            Dexterity=3;
            health= 100;

        }
        public Person(string name,int strength,int intelligence,int dexterity,int givenhealth)
        {
            Name=name;
            Strength=strength;
            Intelligence=intelligence;
            Dexterity=dexterity;
            health= givenhealth;

        }

        public virtual int Attack(Person target)
        {
            int dmg = this.Strength *5;
            
            target.health-=dmg ;
            return target.health;
            
        }
    }
}