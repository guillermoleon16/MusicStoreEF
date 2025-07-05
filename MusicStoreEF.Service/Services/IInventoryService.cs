

using MusicStoreEF.Service.Models;

namespace MusicStoreEF.Service.Services;
public interface IInventoryService
{
    // Define methods for managing inventory records
    Task<IEnumerable<InventoryRecord>> GetAllInventoryRecordsAsync();
    Task<InventoryRecord> GetInventoryRecordByIdAsync(int id);
    Task AddInventoryRecordAsync(InventoryRecord inventoryRecord);
    Task UpdateInventoryRecordAsync(InventoryRecord inventoryRecord);
    Task DeleteInventoryRecordAsync(int id);
}
