using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    [NotMapped]
    public class ViewModel
    {
        public User User{get;set;}
        public Transaction Transaction{get;set;}
        public List<Transaction> Transactions{get;set;}
        public List<User> Users{get;set;}
    }
}