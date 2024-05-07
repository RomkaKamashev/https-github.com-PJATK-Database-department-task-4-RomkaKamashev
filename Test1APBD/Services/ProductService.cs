using Test1APBD.Models;
using Test1APBD.Repositories;

namespace Test1APBD.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IEnumerable<Product> GetProducts()
    {
         
        return _productRepository.GetProducts();
    }
}