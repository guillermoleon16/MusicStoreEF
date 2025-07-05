namespace MusicStoreEF.Service.Models;
public class PurchaseOrder
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    public MusicRecord Record { get; set; } = new MusicRecord();

    public int Quantity { get; set; }
}
