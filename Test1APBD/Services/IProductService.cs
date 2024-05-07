using Test1APBD.Models;

namespace Test1APBD.Services;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
}

