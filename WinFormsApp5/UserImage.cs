using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp5; 

public class UserImage 
{
    [Key]
    [ForeignKey(nameof(Client))]
    public int Id { get; set; }

    public byte[] Cover { get; set; } = null!;

    public Image? GetImage() 
    {
        if (Cover != null) 
        {
            using(var stream = new MemoryStream(Cover)) 
            {
                Image img= Image.FromStream(stream);
                return img;
            }
        }
        return null;
    }

    public User Client { get; set; } = null!;
}
