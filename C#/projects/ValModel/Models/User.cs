using System.ComponentModel.DataAnnotations;

namespace ValModel.Models

{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name="Firstname:")]
        public string FirstName{get; set;}

        [Required]
        [MinLength(4)]
        [Display(Name="Lastname:")]

        public string LastName{get; set;}

        [Required]
        [Range(13,125)]
        [Display(Name="Age:")]

        public int Age{get; set;}
        [Required]
        [EmailAddress]
        [Display(Name="Email:")]
        
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password:")]
        public string Password{get; set;}
    }
}