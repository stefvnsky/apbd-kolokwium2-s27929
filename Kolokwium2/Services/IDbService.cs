using Kolokwium2.DTOs;

namespace Kolokwium2.Services;

public interface IDbService
{
    //GET /api/galleries/{id}/exhibitions
    Task GetGalleryExhibitionsAsync(int galleryId);
}