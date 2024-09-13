using Ingresso.Core.Models.Corporation;

namespace Ingresso.Core.Infra;

public interface ICorpRepository
{
    public Task<Corp> CreateCorp(Corp corp);
    public Task<Corp> UpdateById(Guid corpId, Corp corp);
    public Task<Corp> DeleteById(Guid corpId);
    public Task<List<Corp>> SearchById(Guid corpId);
}