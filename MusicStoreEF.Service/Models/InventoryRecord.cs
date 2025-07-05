namespace MusicStoreEF.Service.Models;
public class InventoryRecord
{
    public int Id { get; set; }

    public MusicRecord Record { get; set; } = new MusicRecord();

    public int Count { get; set; }
}
