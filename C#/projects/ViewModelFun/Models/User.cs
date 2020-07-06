namespace ViewModelFun.Models
{
    public class User
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public User(){}
        public User(string firstname,string lastname)
        {
        FirstName=firstname;
        LastName=lastname;
        }
        
    }
}