using MusicStoreEF.Service.Models;

namespace MusicStoreEF.API.DTO;

public record InventoryRecordDto
{
    public int Id { get; set; }

    public MusicRecord Record { get; set; } = new MusicRecord();

    public int Count { get; set; }
}
