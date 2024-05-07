using System.ComponentModel.DataAnnotations;

namespace Test1APBD.Models;

public class OrderItem
{
    public int OrderItemId { get; set; }
    public int OrderId { get; set; }
    public int ProductID { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public double Price{ get; set; }
}