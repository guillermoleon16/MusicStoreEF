using MusicStoreEF.Infrastructure.Models;

namespace MusicStoreEF.Infrastructure.Interfaces;
public interface IMusicRecordRepository
{
    // Define methods for managing music records
    Task<IEnumerable<MusicRecordEntity>> GetAllMusicRecordsAsync();
    Task<MusicRecordEntity> GetMusicRecordByIdAsync(int id);
    Task AddMusicRecordAsync(MusicRecordEntity musicRecord);
    Task UpdateMusicRecordAsync(MusicRecordEntity musicRecord);
    Task DeleteMusicRecordAsync(int id);
}
