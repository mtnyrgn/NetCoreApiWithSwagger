using API.Models;
using System;
using System.Collections.Generic;
namespace API.Services
{
    public class ProductService : IProductService
    {
        public static List<Product> productList = new List<Product>()
        {
            new Product { Id = 1, Name = "Product 1", Count = 5, Price = 11.8},
            new Product { Id = 2, Name = "Product 2", Count = 10, Price = 20},
            new Product { Id = 3, Name = "Product 3", Count = 15, Price = 2.8},
            new Product { Id = 4, Name = "Product 4", Count = 25, Price = 1.9},
            new Product { Id = 5, Name = "Product 5", Count = 35, Price = 22.3},
            new Product { Id = 6, Name = "Product 6", Count = 25, Price = 27.6},
            new Product { Id = 7, Name = "Product 7", Count = 15, Price = 31.8},
            new Product { Id = 8, Name = "Product 8", Count = 10, Price = 42.9},
            new Product { Id = 9, Name = "Product 9", Count = 5, Price = 51.8},
            new Product { Id = 10, Name = "Product 10", Count = 1, Price = 68.8},
        };
        public void DeleteProduct(Product product)
        {
            productList.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return productList;
        }

        public Product GetProduct(long id)
        {
            return productList.Find(f => f.Id == id);
        }

        public void InsertProduct(Product product)
        {
            productList.Add(product);
        }
    }
}
