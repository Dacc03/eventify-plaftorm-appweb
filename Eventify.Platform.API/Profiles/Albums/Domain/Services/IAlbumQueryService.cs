using Eventify.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventify.Platform.API.Profiles.Albums.Domain.Model.Queries;

namespace Eventify.Platform.API.Profiles.Albums.Domain.Services;

public interface IAlbumQueryService
{
    Task<IEnumerable<Album>> Handle(GetAllAlbumsQuery query);
    Task<Album?> Handle(GetAlbumByIdQuery query);
}
