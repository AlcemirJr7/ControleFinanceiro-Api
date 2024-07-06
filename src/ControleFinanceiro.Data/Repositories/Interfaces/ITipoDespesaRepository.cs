using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Data.Repositories.Interfaces
{
    public interface ITipoDespesaRepository
    {
        Task<TipoDespesa?> GetByIdAsync(Guid id);
        Task<IEnumerable<TipoDespesa>?> GetAll();
        Task<TipoDespesa> InsertAsync(TipoDespesa tipoDespesa);
        Task<TipoDespesa> DeleteAsync(TipoDespesa tipoDespesa);
        Task<TipoDespesa> UpdateAsync(TipoDespesa tipoDespesa);
    }
}
