using JWTDemo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JWTDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet, Authorize]
        public IEnumerable<Product> Get()
        {
            var currentUser = HttpContext.User;
            var productList = new Product[] {
        new Product { Id =1 , Name = "Sunglasses",Description = "This is test description 1", Price = 10 },
        new Product { Id =1 , Name = "Mouse",Description = "This is test description 2", Price = 8 },
        new Product { Id =1 , Name = "Pen",Description = "This is test description 3", Price = 3 },
        new Product { Id =1 , Name = "Ink",Description = "This is test description 4", Price = 1 },

      };

            return productList;
        }
    }
}