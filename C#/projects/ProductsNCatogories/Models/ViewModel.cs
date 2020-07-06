using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsNCatogories.Models
{
    [NotMapped]
    public class ViewModel
    {
        public List<Product> Products {set;get;}
        public List<Category> Categories {set;get;}
        public Product Product{get; set;}
        public Category Category{get; set;}
        public ProductsInCaegory ProductsInCaegory{get;set;}
        public List<ProductsInCaegory> ProductsInCaegories{get;set;} 

    }
}