namespace MusicStoreEF.Infrastructure.Models;
public class InventoryRecordEntity
{
    public int Id { get; set; }

    public MusicRecordEntity Record { get; set; } = new MusicRecordEntity();

    public int Count { get; set; }
}
