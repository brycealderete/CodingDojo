using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID{get;set;}
        [Required(ErrorMessage = "is required")]
        public double Amount{get;set;}
        public User User{get;set;}
        public int UserId{get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}