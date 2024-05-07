using Test1APBD.Models;
using Microsoft.AspNetCore.Mvc;
using Test1APBD.Services;

namespace Test1APBD.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ECommerceController : ControllerBase
{
    private IProductService _productService;

    public ECommerceController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public IActionResult GetProduct()
    {
        var products = _productService.GetProducts();
        return Ok(products);
    }
    
}