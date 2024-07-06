using ControleFinanceiro.Data.Context;
using ControleFinanceiro.Data.Repositories.Interfaces;
using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Data.Repositories
{
    public class TipoDespesaRepository : ITipoDespesaRepository
    {
        private readonly AppDbContext _appDbContext;
        public TipoDespesaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<TipoDespesa> DeleteAsync(TipoDespesa tipoDespesa)
        {
            _appDbContext.Remove(tipoDespesa);
            await _appDbContext.SaveChangesAsync();
            return tipoDespesa;
        }

        public async Task<IEnumerable<TipoDespesa>?> GetAll()
        {
            return await _appDbContext.TipoDespesas.ToListAsync();
        }

        public async Task<TipoDespesa?> GetByIdAsync(Guid id)
        {
            return await _appDbContext.TipoDespesas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TipoDespesa> InsertAsync(TipoDespesa tipoDespesa)
        {
            _appDbContext.Add(tipoDespesa);
            await _appDbContext.SaveChangesAsync();
            return tipoDespesa;
        }

        public async Task<TipoDespesa> UpdateAsync(TipoDespesa tipoDespesa)
        {
            _appDbContext.Update(tipoDespesa);
            await _appDbContext.SaveChangesAsync();
            return tipoDespesa;
        }
    }
}
