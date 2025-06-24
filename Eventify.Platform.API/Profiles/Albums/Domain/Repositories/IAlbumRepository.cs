using Eventify.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventify.Platform.API.Shared.Domain.Repositories;

namespace Eventify.Platform.API.Profiles.Albums.Domain.Repositories;

public interface IAlbumRepository : IBaseRepository<Album>
{
}
