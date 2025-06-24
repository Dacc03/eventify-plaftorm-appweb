using System.Collections.Generic;
using Eventify.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventify.Platform.API.Profiles.Albums.Domain.Model.Queries;
using Eventify.Platform.API.Profiles.Albums.Domain.Repositories;
using Eventify.Platform.API.Profiles.Albums.Domain.Services;

namespace Eventify.Platform.API.Profiles.Albums.Application.Internal.QueryServices;

public class AlbumQueryService(
    IAlbumRepository albumRepository
) : IAlbumQueryService
{
    public async Task<IEnumerable<Album>> Handle(GetAllAlbumsQuery query)
    {
        return await albumRepository.ListAsync();
    }

    public async Task<Album?> Handle(GetAlbumByIdQuery query)
    {
        return await albumRepository.FindByIdAsync(query.AlbumId);
    }
}
