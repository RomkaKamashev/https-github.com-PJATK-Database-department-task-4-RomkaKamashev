using System.ComponentModel.DataAnnotations;

namespace Test1APBD.Models;

public class Customer
{
    public int CustomerID{ get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName{ get; set; }
    [Required]
    [MaxLength(50)]
    public string Lastname{ get; set; }
    [Required]
    [MaxLength(100)]
    [EmailAddress]
    public string Email{ get; set; }
}