namespace Kolokwium2.DTOs;

public class GalleryResponseDTO
{
    //GET
    public int GalleryId { get; set; }
    public string Name { get; set; }
    public DateTime EstablishedDate { get; set; }
    
    public List<GalleryExhibitionResponseDTO> Exhibitions { get; set; }
}