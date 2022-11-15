using System.ComponentModel.DataAnnotations;

namespace WebApiEntityFramework.Models;

public class DogViewModel
{
    [Required]
    public string Name {get;set;}

    [Required]
    public string Breed { get; set; }

    [Required]
    public int? Age { get; set; }

    public bool HasAllShots { get; set; }
}