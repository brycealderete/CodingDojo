using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsNCatogories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId{get;set;}
        [Required(ErrorMessage="is Required")]
        [MinLength(2,ErrorMessage="Must be at least 2 characters")]
        public string Name{get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        
        
        public List<ProductsInCaegory> ProductsInCaegories{get;set;}
    }
}