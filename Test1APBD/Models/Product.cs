using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Test1APBD.Models;

public class Product
{
    public int ProductID { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    public string Description{ get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    public int StockQuantity { get; set; }
}