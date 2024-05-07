using System.Data.SqlClient;
using Test1APBD.Models;

namespace Test1APBD.Repositories;

public class ProductRepository : IProductRepository
{
    private IConfiguration _configuration;

    public ProductRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IEnumerable<Product> GetProducts()
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select ProductID, Name, Description, Price, StockQuantity FROM Product order by Name";

        var dr = cmd.ExecuteReader();
        var products = new List<Product>();
        
        while (dr.Read())
        {
            var prod = new Product
            {
                ProductID = (int)dr["ProductID"],
                Name = dr["Name"].ToString(),
                Description = dr["Description"].ToString(),
                Price = (int)dr["Price"],
                StockQuantity = (int)dr["StockQuantity"]
            };
            products.Add(prod);

        }

        return products;
    }

}
