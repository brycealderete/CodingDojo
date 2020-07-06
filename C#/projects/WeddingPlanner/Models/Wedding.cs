using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId{get;set;}
        [Required(ErrorMessage="Is required")]
        [MinLength(2,ErrorMessage="Must be 2 characters long")]
        [Display(Name="Wedder One")]
        public string WedderOne{get;set;}
        [Required(ErrorMessage="Is required")]
        [MinLength(2,ErrorMessage="Must be 2 characters long")]
        [Display(Name="Wedder Two")]
        public string WedderTwo{get;set;}
        [Required(ErrorMessage="Is required")]
        public DateTime Date{get;set;}
        [Required(ErrorMessage="Is required")]
        [MinLength(10,ErrorMessage="Must be 10 characters long")]
        [Display(Name="Address")]
        public string Address{get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId{get;set;}
        public User User{get;set;}
        public List<UserGoingtoWedding> UsersgoingtoWeddings {get;set;}


        
    }
}