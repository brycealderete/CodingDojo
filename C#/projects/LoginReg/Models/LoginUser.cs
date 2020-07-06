using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Key]
        public int LoginUserId{get;set;}
        [Required(ErrorMessage = "is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(8, ErrorMessage = "must be at least 8 characters")]
        [DataType(DataType.Password)] 
        [Display(Name = "Password")]
        public string LoginPassword { get; set; }
    }
}