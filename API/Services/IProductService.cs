using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IProductService
    {
        Product GetProduct(long id);
        List<Product> GetAllProducts();
        void InsertProduct(Product product);
        void DeleteProduct(Product product);
    }
}
