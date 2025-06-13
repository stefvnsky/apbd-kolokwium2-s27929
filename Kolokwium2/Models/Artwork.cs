using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

[Table("Artwork")]
public class Artwork
{
    [Key]
    public int ArtworkId { get; set; }
    
    [ForeignKey(nameof(Artist))]
    public int ArtistId { get; set; }

    public Artist Artist { get; set; } = null!; //relacje nawigacyjne

    [MaxLength(100)] public string Title { get; set; } = null!;
    
    public int YearCreated { get; set; }
    
    //nawigacja
    public ICollection<ExhibitionArtwork> ExhibitionArtworks { get; set; } = null!;
}