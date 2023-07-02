using System.ComponentModel.DataAnnotations;

namespace AnimalShelterAPI.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    [Range(0, 30, ErrorMessage = "Age must be between 0 and 30.")]
    public int Age { get; set; }
  }
}
