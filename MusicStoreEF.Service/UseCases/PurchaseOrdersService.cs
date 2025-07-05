using MusicStoreEF.Service.Models;
using MusicStoreEF.Service.Services;

namespace MusicStoreEF.Service.UseCases;
public class PurchaseOrdersService : IPurchaseOrdersService
{
    public Task AddPurchaseOrderAsync(PurchaseOrder purchaseOrder)
    {
        throw new NotImplementedException();
    }

    public Task DeletePurchaseOrderAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrdersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PurchaseOrder> GetPurchaseOrderByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePurchaseOrderAsync(PurchaseOrder purchaseOrder)
    {
        throw new NotImplementedException();
    }
}
