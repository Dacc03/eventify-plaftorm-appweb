using Eventify.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventify.Platform.API.Profiles.Albums.Domain.Model.Commands;

namespace Eventify.Platform.API.Profiles.Albums.Domain.Services;

public interface IAlbumCommandService
{
    Task<Album?> Handle(CreateAlbumCommand command);
}
