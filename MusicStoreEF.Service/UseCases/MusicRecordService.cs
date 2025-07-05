using MusicStoreEF.Service.Models;
using MusicStoreEF.Service.Services;

namespace MusicStoreEF.Service.UseCases;
public class MusicRecordService : IMusicRecordService
{
    public Task AddMusicRecordAsync(MusicRecord musicRecord)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMusicRecordAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MusicRecord>> GetAllMusicRecordsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<MusicRecord> GetMusicRecordByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMusicRecordAsync(MusicRecord musicRecord)
    {
        throw new NotImplementedException();
    }
}
