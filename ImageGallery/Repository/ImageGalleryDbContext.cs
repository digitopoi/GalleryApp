using ImageGallery.Models;
using Microsoft.EntityFrameworkCore;


namespace ImageGallery.Repository
{
    public class ImageGalleryDbContext : DbContext
    {
        public ImageGalleryDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }

    }
}
