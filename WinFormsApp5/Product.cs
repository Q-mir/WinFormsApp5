using System.ComponentModel.DataAnnotations;

namespace WinFormsApp5; 

public class Product
{
    [Key]
    [Required]
    public int Id { get; set; }

    [MaxLength(150)]
    [Required]
    public string Name { get; set; } = null!;

    [MaxLength(1000)]
    public string Description { get; set; } = null!;

    [Range(1,double.MaxValue)]
    [Required]
    public double Price { get; set; }

}
