using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheifnDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {set; get;}
        [Required(ErrorMessage = "is required")]
	    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
	    [Display(Name = "First Name")]

        public string FirstName{set; get;}
        [Required(ErrorMessage = "is required")]
	    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
	    [Display(Name = "Last Name")]

        public string LastName {set; get;}
        [Required(ErrorMessage = "is required")]
	    [Display(Name = "Birthday")]

        public DateTime Birthday{get;set;}
        public List<Dish> Dishes {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}