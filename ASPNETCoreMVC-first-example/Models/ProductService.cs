using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Models
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            List<Product> productList = new List<Product>(){
            new Product { Id = 1, Name = "Nike Kyrie 2", SKU ="NK2", Price = 109},
            new Product { Id = 2, Name ="Nike Sock Dart", SKU ="NSD",Price = 150},
            new Product { Id = 3, Name ="Nike Air Max Zero", SKU ="NAMZ",Price = 140},
            new Product { Id = 4, Name ="Nike Superfly3", SKU ="NSF3",Price = 120}
            };

            return productList;
        }

    }
}
