using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTutorial.Api.Models;

namespace WebApiTutorial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<ProductModel> products = new List<ProductModel>() {
            new ProductModel { ProductId = 1, ProductName = "Shirt", Price = 10.00m},
            new ProductModel { ProductId = 2, ProductName = "Jeans", Price = 15.00m},
            new ProductModel { ProductId = 3, ProductName = "T-Shirt", Price = 12.00m},
        };
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts() {
            return Ok(products);
        }
    }
}