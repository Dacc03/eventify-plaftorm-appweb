using System.Collections.Generic;

namespace Eventify.Platform.API.Profiles.Albums.Interfaces.REST.Resources;

public record AlbumResource(
    int Id,
    int ProfileId,
    string Name,
    IEnumerable<string> Photos);
