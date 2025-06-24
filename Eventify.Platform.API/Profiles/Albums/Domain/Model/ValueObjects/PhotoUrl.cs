namespace Eventify.Platform.API.Profiles.Albums.Domain.Model.ValueObjects;

public record PhotoUrl(string Url)
{
    public PhotoUrl() : this(string.Empty)
    {
    }
}
