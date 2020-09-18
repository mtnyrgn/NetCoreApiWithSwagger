using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }

        [HttpPost]
        public IActionResult InsertProduct(Product product)
        {
            try
            {
                _productService.InsertProduct(product);
                return Ok(new { Success = true, Message = "Product inserted successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Success = false, Message = "Unexpected error" });
            }
        }

        [HttpGet]
        [Route("GetProduct/{id}")]
        public IActionResult GetProduct(long id)
        {
            try
            {
                Product product = _productService.GetProduct(id);

                if(!(product is null))
                {
                    return Ok(new { Success = true, Message = "Product found successfully!", Data = product });
                }
                else
                {
                    return Ok(new { Success = true, Message = "Product cannot found!!"});
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { Success = false, Message = "Unexpected error" });
            }
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(long id)
        {
            try
            {
                Product product = _productService.GetAllProducts().FirstOrDefault(f => f.Id == id);
                _productService.DeleteProduct(product);
                return Ok(new { Success = true, Message = "Product deleted successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Success = false, Message = "Unexpected error" });
            }
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            try
            {
                List<Product> productList = _productService.GetAllProducts();
                return Ok(new { Success = true, Data = productList });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Success = false, Message = "Unexpected error" });
            }
            
        }
    }
}
