using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Data.Repositories.Interfaces
{
    public interface IReceitaRepository
    {
        Task<Receita?> GetByIdAsync(Guid id);
        Task<IEnumerable<Receita>?> GetAllAsync();
        Task<Receita> InsertAsync(Receita receita);
        Task<Receita> DeleteAsync(Receita receita);
        Task<Receita> UpdateAsync(Receita receita);
    }
}
