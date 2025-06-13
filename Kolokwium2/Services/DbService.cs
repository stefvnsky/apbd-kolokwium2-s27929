using Kolokwium2.Data;
using Kolokwium2.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    //konstruktor
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task GetGalleryExhibitionsAsync(int galleryId)
    {
        var gallery = await _context.Galleries
            .Where(g => g.GalleryId == galleryId)
            .Select(g => new GalleryResponseDTO
            {
                GalleryId = g.GalleryId,
                Name = g.Name,
                EstablishedDate = g.EstablishedDate,
                
                Exhibitions = g.Exhibitions.Select(ge => new GalleryExhibitionResponseDTO
                {
                    Title = ge.Title,
                    StartDate = ge.StartDate,
                    EndDate = ge.EndDate,
                    NumberOfArtworks = ge.NumberOfArtworks
                }).ToList()
            }).FirstOrDefaultAsync();
    }
}