using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Data.Repositories.Interfaces
{
    public interface IDespesaRepository
    {
        Task<Despesa?> GetByIdAsync(Guid id);
        Task<IEnumerable<Despesa>?> GetAllAsync();
        Task<Despesa> InsertAsync(Despesa despesa);
        Task<Despesa> DeleteAsync(Despesa despesa);
        Task<Despesa> UpdateAsync(Despesa despesa);
    }
}
