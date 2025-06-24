using System.Collections.Generic;

namespace Eventify.Platform.API.Profiles.Albums.Interfaces.REST.Resources;

public record CreateAlbumResource(
    int ProfileId,
    string Name,
    List<string> Photos);
