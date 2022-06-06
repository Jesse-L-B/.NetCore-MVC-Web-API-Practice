using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using APIHomework.Models;

namespace APIHomework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> products;
        public ProductController()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "Silky Shampoo", Price = 9, Category = "Toiletries" });
            products.Add(new Product() { Id = 2, Name = "Silky Conditioner", Price = 8, Category = "Toiletries" });
            products.Add(new Product() { Id = 3, Name = "Charcoal Face Scrubber", Price = 5, Category = "Toiletries" });
            products.Add(new Product() { Id = 4, Name = "Sunglasses", Price = 20, Category = "Accessories" });
            products.Add(new Product() { Id = 5, Name = "Baseball Cap", Price = 13, Category = "Accessories" });
            products.Add(new Product() { Id = 6, Name = "Tylenol", Price = 5, Category = "Medicine" });
            products.Add(new Product() { Id = 7, Name = "Ecedrine", Price = 6, Category = "Medicine" });

        }
        [HttpGet]
        public List<Product> GetProducts()
        {
            return products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = this.products.Find(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
