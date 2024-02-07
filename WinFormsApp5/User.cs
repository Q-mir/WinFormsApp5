using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WinFormsApp5;

[Table("Client")]
public class User 
{
    [Key]       //Primary key
    [Required]  //not null
    public int Id { get; set; }

    [Required]
    [MaxLength(15)] //nvarchar(15)
    public string Login { get; set; } = null!; 

    [Required]
    [MaxLength(10)]
    public string Password { get; set; } = null!; 
}

