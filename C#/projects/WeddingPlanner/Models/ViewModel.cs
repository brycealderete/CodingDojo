using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class ViewModel
    {
        public User User{get;set;}
        public List<User> Users {get;set;}
        public Wedding Wedding {get;set;}
        public List<Wedding> Weddings {get;set;}
        public LoginUser LoginUser{get;set;}

        public UserGoingtoWedding UserGoingtoWedding{get;set;}
        public List<UserGoingtoWedding> UsersGoingtoWeddings{get;set;}
    }
}