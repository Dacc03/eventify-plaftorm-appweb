using Eventify.Platform.API.Profiles.Albums.Domain.Model.Aggregates;
using Eventify.Platform.API.Profiles.Albums.Domain.Model.Commands;
using Eventify.Platform.API.Profiles.Albums.Domain.Repositories;
using Eventify.Platform.API.Profiles.Albums.Domain.Services;
using Eventify.Platform.API.Shared.Domain.Repositories;
using Eventify.Platform.API.Profiles.Interfaces.ACL;
using System.Linq;

namespace Eventify.Platform.API.Profiles.Albums.Application.Internal.CommandServices;

public class AlbumCommandService(
    IAlbumRepository albumRepository,
    IUnitOfWork unitOfWork,
    IProfilesContextFacade profilesContextFacade) : IAlbumCommandService
{
    public async Task<Album?> Handle(CreateAlbumCommand command)
    {
        if (command.Photos.Count() > 10) return null;
        if (!await profilesContextFacade.ProfileExists(command.ProfileId)) return null;
        var album = new Album(command);
        try
        {
            await albumRepository.AddAsync(album);
            await unitOfWork.CompleteAsync();
            return album;
        }
        catch
        {
            return null;
        }
    }
}
