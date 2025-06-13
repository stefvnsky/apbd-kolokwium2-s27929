using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Exhibition> Exhibitions { get; set; } 
    public DbSet<Artwork> Artworks { get; set; }
    public DbSet<Gallery> Galleries { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Exhibition> ExhibitionArtworks { get; set; }
    
    public DatabaseContext() 
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artist>().HasData(new List<Artist>()
        {
            new Artist
            {
                ArtistId = 1,
                FirstName = "Pablo",
                LastName = "Picasso",
                BirthDate = new DateTime(1881, 10, 25)
            },
            new Artist
            {
                ArtistId = 2,
                FirstName = "Frida",
                LastName = "Kahlo",
                BirthDate = new DateTime(1907, 07, 06)
            }
        });
        modelBuilder.Entity<Artwork>().HasData(new List<Artwork>()
        {
            new Artwork
            {
                ArtworkId = 1,
                ArtistId = 1,
                Title = "Guernica",
                YearCreated = 1937
            },
            new Artwork
            {
                ArtworkId = 2,
                ArtistId = 2,
                Title = "The Two Fridas",
                YearCreated = 1939
            }
        });
        modelBuilder.Entity<Gallery>().HasData(new List<Gallery>()
        {
            new Gallery
            {
                GalleryId = 1,
                Name = "Modern Art Space",
                EstablishedDate = new DateTime(2001,09,12)
            }
        });
        modelBuilder.Entity<Exhibition>().HasData(new List<Exhibition>()
        {
            new Exhibition
            {
                ExhibitionId = 1,
                GalleryId = 1,
                Title = "20th Century Giants",
                StartDate = new DateTime(2024, 05, 01),
                EndDate = new DateTime(2024,09,01),
                NumberOfArtworks = 2
            }
        });
        modelBuilder.Entity<ExhibitionArtwork>().HasData(new List<ExhibitionArtwork>()
        {
            new ExhibitionArtwork
            {
                ExhibitionId = 1,
                ArtworkId = 1,
                InsuranceValue = 1000000.00
            }
        });
    }
}