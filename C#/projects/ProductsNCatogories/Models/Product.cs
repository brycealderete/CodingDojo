using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsNCatogories.Models
{
    public class Product
    {
        [Key]
        public int ProductId{get;set;}
        [Required(ErrorMessage="is Required")]
        [MinLength(2,ErrorMessage="Must be at least 2 characters")]
        public string Name{get;set;}

        [Required(ErrorMessage="is Required")]
        [MinLength(2,ErrorMessage="Must be at least 2 characters")]
        public string Description{get;set;}

        [Required(ErrorMessage="is Required")]
        public double Price{get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<ProductsInCaegory> ProductsInCaegories{get;set;}

    }
}