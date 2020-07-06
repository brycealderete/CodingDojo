using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class User
    {
        [Key]
        public int DishrId { get; set; }
	    [Required(ErrorMessage = "is required")]
	    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
	    [Display(Name = "First Name")]
	    public string FirstName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
	}
}