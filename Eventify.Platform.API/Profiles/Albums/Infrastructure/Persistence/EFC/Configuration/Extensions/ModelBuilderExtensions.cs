using Eventify.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace Eventify.Platform.API.Profiles.Albums.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyAlbumsConfiguration(this ModelBuilder builder)
    {
        builder.Entity<Album>().HasKey(a => a.Id);
        builder.Entity<Album>()
            .Property(a => a.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        builder.Entity<Album>()
            .Property(a => a.Name)
            .IsRequired();
        builder.Entity<Album>()
            .Property(a => a.ProfileId)
            .IsRequired();
        builder.Entity<Album>().OwnsMany(a => a.Photos, p =>
        {
            p.WithOwner().HasForeignKey("AlbumId");
            p.Property<int>("Id");
            p.HasKey("Id");
            p.Property(ph => ph.Url).HasColumnName("Url");
        });
    }
}
