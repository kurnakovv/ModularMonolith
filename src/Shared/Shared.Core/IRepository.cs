namespace Shared.Core;

public interface IRepository<TPOCO> : IAsyncDisposable
    where TPOCO : IBasePOCO
{
    Task<IEnumerable<TPOCO>> GetAsync();
    Task<TPOCO> GetAsync(long id);
    Task<long> CreateAsync(TPOCO entity);
    Task UpdateAsync(TPOCO entity);
    Task DeleteAsync(long id);
}
