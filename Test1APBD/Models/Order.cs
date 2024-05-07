using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Test1APBD.Models;

public class Order
{
    public int OrderId { get; set; }
    public int CustomerID { get; set; }
    [Required]
    public int OrderDate { get; set; }
    [Required]
    public double TotalAmount { get; set; }
}