using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

[Table("Gallery")]
public class Gallery
{
    [Key]
    public int GalleryId { get; set; }

    [MaxLength(50)] public string Name { get; set; } = null!;
    
    public DateTime EstablishedDate { get; set; }
    
    //nawigacja
    public ICollection<Exhibition> Exhibitions { get; set; } = null!;
}