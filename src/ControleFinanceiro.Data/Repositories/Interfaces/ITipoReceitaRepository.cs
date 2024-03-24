using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Data.Repositories.Interfaces
{
    public interface ITipoReceitaRepository
    {
        Task<TipoReceita?> GetByIdAsync(Guid id);
        Task<IEnumerable<TipoReceita>?> GetAll();
        Task<TipoReceita> InsertAsync(TipoReceita tipoReceita);
        Task<TipoReceita> DeleteAsync(TipoReceita tipoReceita);
        Task<TipoReceita> UpdateAsync(TipoReceita tipoReceita);
    }
}
