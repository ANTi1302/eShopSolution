using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
   public class ProductInCaterogy
    {
        public int productId { get; set; }
        public int categoryId { get; set; }
        public Category category { get; set; }
        public Product product { get; set; }
       
    }
}
