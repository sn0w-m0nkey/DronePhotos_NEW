using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class PhotosDbContext : DbContext
{
    public DbSet<Photo> Photos { get; set; }
    
    public PhotosDbContext(DbContextOptions<PhotosDbContext> options)
        : base(options)
    {
    }
}
