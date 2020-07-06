using System;
using System.ComponentModel.DataAnnotations;

namespace ProductsNCatogories.Models
{
    public class ProductsInCaegory
    {
        [Key]
        public int ProductsInCaegoryId{get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Display(Name="Category :")]

        public int CategoryId{get;set;}
        public int ProductId{get;set;}
        public Category Category{get;set;}
        public Product Product{get;set;}
        
    }
}