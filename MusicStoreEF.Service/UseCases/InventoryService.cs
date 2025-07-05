using MusicStoreEF.Infrastructure.Interfaces;
using MusicStoreEF.Infrastructure.Models;
using MusicStoreEF.Service.Models;
using MusicStoreEF.Service.Services;

namespace MusicStoreEF.Service.UseCases;
public class InventoryService : IInventoryService
{
    private readonly IInventoryRepository _inventoryRepository;

    public InventoryService(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository ?? throw new ArgumentNullException(nameof(inventoryRepository));
    }   

    public Task AddInventoryRecordAsync(InventoryRecord inventoryRecord)
    {
        var record = new InventoryRecordEntity
        {
            Id = inventoryRecord.Id,
            Record = inventoryRecord.Record,
            Count = inventoryRecord.Count
        };

        return _inventoryRepository.AddInventoryRecordAsync(record);
    }

    public Task DeleteInventoryRecordAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<InventoryRecord>> GetAllInventoryRecordsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<InventoryRecord> GetInventoryRecordByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateInventoryRecordAsync(InventoryRecord inventoryRecord)
    {
        throw new NotImplementedException();
    }
}
