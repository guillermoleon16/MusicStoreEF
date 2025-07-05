using MusicStoreEF.Service.Models;

namespace MusicStoreEF.Service.Services;
public interface IMusicRecordService
{
    // Define methods for managing music records
    Task<IEnumerable<MusicRecord>> GetAllMusicRecordsAsync();
    Task<MusicRecord> GetMusicRecordByIdAsync(int id);
    Task AddMusicRecordAsync(MusicRecord musicRecord);
    Task UpdateMusicRecordAsync(MusicRecord musicRecord);
    Task DeleteMusicRecordAsync(int id);
}
