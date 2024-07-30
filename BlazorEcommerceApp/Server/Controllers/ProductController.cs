﻿using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerceApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {        
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        } 
        [HttpGet]
        //public ActionResult<List<Product>> GetProduct() //szinkron
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }
        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }
        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductByCategory(string categoryUrl)
        {
            var result = await _productService.GetProductsByCategory(categoryUrl);
            return Ok(result);
        }
    }
}

