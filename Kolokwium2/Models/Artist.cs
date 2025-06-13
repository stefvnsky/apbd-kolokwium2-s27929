using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

[Table("Artist")]
public class Artist
{
    [Key]
    public int ArtistId { get; set; }

    [MaxLength(100)] public string FirstName { get; set; } = null!;

    [MaxLength(100)] public string LastName { get; set; } = null!;
    
    public DateTime BirthDate { get; set; }
    
    //nawigacja
    public ICollection<Artwork> Artworks { get; set; } = null!;
}