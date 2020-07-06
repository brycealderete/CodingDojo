using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishrId { get; set; }
	    [Required(ErrorMessage = "is required")]
	    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
	    [Display(Name = "First Name")]
	    public string CheifName { get; set; }
        [Required]
	    public string DishName { get; set; }
        [Required]
	    public int Calories { get; set; }
        [Required]

	    public int TasteRating { get; set; }
	    public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
	}
    
}