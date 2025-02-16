namespace HotCocoChinook.Types;

public class Track
{
    public required int TrackId { get; set; }
    public required string Name { get; set; }
    public int? AlbumId { get; set; }
    public required int MediaTypeId { get; set; }
    public int? GenreId { get; set; }
    public string? Composer { get; set; }
    public required int Milliseconds { get; set; }
    public int? Bytes { get; set; }
    public required long UnitPrice { get; set; }
}