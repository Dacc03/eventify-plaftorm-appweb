using System.Collections.Generic;

namespace Eventify.Platform.API.Profiles.Albums.Domain.Model.Commands;

public record CreateAlbumCommand(
    int ProfileId,
    string Name,
    IEnumerable<string> Photos);
