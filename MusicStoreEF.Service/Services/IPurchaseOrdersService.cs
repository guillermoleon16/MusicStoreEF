using MusicStoreEF.Service.Models;

namespace MusicStoreEF.Service.Services;
public interface IPurchaseOrdersService
{
    // Define methods for managing purchase orders
    Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrdersAsync();
    Task<PurchaseOrder> GetPurchaseOrderByIdAsync(int id);
    Task AddPurchaseOrderAsync(PurchaseOrder purchaseOrder);
    Task UpdatePurchaseOrderAsync(PurchaseOrder purchaseOrder);
    Task DeletePurchaseOrderAsync(int id);
}
