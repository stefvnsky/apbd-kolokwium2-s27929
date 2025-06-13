using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models;

[Table("Exhibition_Artwork")]
[PrimaryKey(nameof(ExhibitionId), nameof(ArtworkId))]
public class ExhibitionArtwork
{
    [ForeignKey(nameof(Exhibition))]
    public int ExhibitionId { get; set; }
    public Exhibition Exhibition { get; set; } = null!;
    
    [ForeignKey(nameof(Artwork))]
    public int ArtworkId { get; set; }
    public Artwork Artwork { get; set; } = null!;
    
    [Column(TypeName = "numeric")]
    [Precision(10, 2)]
    public double InsuranceValue { get; set; }
}