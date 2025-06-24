using System.Linq;
using Eventify.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventify.Platform.API.Profiles.Albums.Interfaces.REST.Resources;

namespace Eventify.Platform.API.Profiles.Albums.Interfaces.REST.Transform;

public class AlbumResourceFromEntityAssembler
{
    public static AlbumResource ToResourceFromEntity(Album entity)
    {
        var photos = entity.Photos
            .Select(photo => photo.Url)
            .ToList();
        return new AlbumResource(entity.Id, entity.ProfileId, entity.Name, photos);
    }
}
