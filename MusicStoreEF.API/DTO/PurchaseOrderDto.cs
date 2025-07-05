using MusicStoreEF.Service.Models;

namespace MusicStoreEF.API.DTO;

public record PurchaseOrderDto
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    public MusicRecord Record { get; set; } = new MusicRecord();

    public int Quantity { get; set; }
}
