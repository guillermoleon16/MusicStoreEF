namespace MusicStoreEF.Infrastructure.Models;
public class PurchaseOrderEntity
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    public MusicRecordEntity Record { get; set; } = new MusicRecordEntity();

    public int Quantity { get; set; }
}
