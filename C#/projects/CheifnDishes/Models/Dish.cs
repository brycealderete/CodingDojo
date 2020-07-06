using System;
using System.ComponentModel.DataAnnotations;

namespace CheifnDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
	    // [Required(ErrorMessage = "is required")]
	    // [MinLength(2, ErrorMessage = "must be at least 2 characters")]
	    // [Display(Name = "Chef Name")]
	    // public string ChefName { get; set; }

        [Required(ErrorMessage = "is required")]
	    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
	    [Display(Name = "Dish Name")]
	    public string DishName { get; set; }

        [Required(ErrorMessage = "is required")]
	    [Display(Name = "# of Calories")]
	    public int Calories { get; set; }

        [Required(ErrorMessage = "is required")]
	    [Range(1,5,ErrorMessage="Must be between 1 and 5.")]
	    [Display(Name = "Taste Rating")]

	    public int TasteRating { get; set; }
        [Required(ErrorMessage="is Required")]
        [Display(Name="Description")]
        [MinLength(15, ErrorMessage = "must be at least 15 characters")]
	    public string Description { get; set; }
		[Display(Name="Chef Name")]
        public int ChefId {get; set;}
		public Chef Chef{set;get;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
	}
    
}