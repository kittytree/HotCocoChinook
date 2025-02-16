namespace HotCocoChinook.Types;

public class Album(int albumId, string title, int artistId)
{
    public required int AlbumId { get; set; } = albumId;
    public required string Title { get; set; } = title;
    public required int ArtistId { get; set; } = artistId;
}