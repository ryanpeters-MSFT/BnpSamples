using System.ComponentModel.DataAnnotations;

namespace WebApiControllerAttribute.Models;

public class ClientViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a name")]
    public string Name { get; set; }

    [Range(0, 100, ErrorMessage = "Please enter a valid age")]
    public int Age { get; set; }
}
