namespace Kolokwium2.DTOs;

public class GalleryExhibitionResponseDTO
{
    //GET
    public string Title { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int NumberOfArtworks { get; set; }
    
    public List<ArtworkArtistResponseDTO> Artists { get; set; }
}