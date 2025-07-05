namespace MusicStoreEF.API.DTO;

public record MusicRecordDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;
}
