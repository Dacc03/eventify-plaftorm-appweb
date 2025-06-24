using Eventify.Platform.API.Profiles.Albums.Domain.Model.Commands;
using Eventify.Platform.API.Profiles.Albums.Interfaces.REST.Resources;

namespace Eventify.Platform.API.Profiles.Albums.Interfaces.REST.Transform;

public class CreateAlbumCommandFromResourceAssembler
{
    public static CreateAlbumCommand ToCommandFromResource(CreateAlbumResource resource)
    {
        return new CreateAlbumCommand(resource.ProfileId, resource.Name, resource.Photos);
    }
}
