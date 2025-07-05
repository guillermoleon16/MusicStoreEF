using MusicStoreEF.Infrastructure.Models;

namespace MusicStoreEF.Infrastructure.Interfaces;
public interface IPurchaseOrdersRepository
{
    Task<IEnumerable<PurchaseOrderEntity>> GetAllPurchaseOrdersAsync();
    Task<PurchaseOrderEntity> GetPurchaseOrderByIdAsync(int id);
    Task AddPurchaseOrderAsync(PurchaseOrderEntity purchaseOrder);
    Task UpdatePurchaseOrderAsync(PurchaseOrderEntity purchaseOrder);
    Task DeletePurchaseOrderAsync(int id);
}
