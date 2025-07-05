using MusicStoreEF.Infrastructure.Models;

namespace MusicStoreEF.Infrastructure.Interfaces;
public interface IInventoryRepository
{
    // Define methods for managing inventory records
    Task<IEnumerable<InventoryRecordEntity>> GetAllInventoryRecordsAsync();
    Task<InventoryRecordEntity> GetInventoryRecordByIdAsync(int id);
    Task AddInventoryRecordAsync(InventoryRecordEntity inventoryRecord);
    Task UpdateInventoryRecordAsync(InventoryRecordEntity inventoryRecord);
    Task DeleteInventoryRecordAsync(int id);
}
