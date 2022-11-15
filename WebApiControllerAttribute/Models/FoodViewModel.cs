using System.ComponentModel.DataAnnotations;

namespace WebApiControllerAttribute.Models;

public class FoodViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a food name")]
    public string Name { get; set; }

    [Required]
    public string Origin { get; set; }
}
