using Test1APBD.Models;
namespace Test1APBD.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();

}