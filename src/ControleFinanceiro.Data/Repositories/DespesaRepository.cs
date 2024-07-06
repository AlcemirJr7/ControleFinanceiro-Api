using ControleFinanceiro.Data.Context;
using ControleFinanceiro.Data.Repositories.Interfaces;
using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Data.Repositories
{
    public class DespesaRepository : IDespesaRepository
    {
        private readonly AppDbContext _appDbContext;

        public DespesaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Despesa> InsertAsync(Despesa despesa)
        {
            _appDbContext.Add(despesa);
            await _appDbContext.SaveChangesAsync();
            return despesa;
        }

        public async Task<Despesa> DeleteAsync(Despesa despesa)
        {
            _appDbContext.Remove(despesa);
            await _appDbContext.SaveChangesAsync();
            return despesa;
        }

        public async Task<Despesa> UpdateAsync(Despesa despesa)
        {
            _appDbContext.Update(despesa);
            await _appDbContext.SaveChangesAsync();
            return despesa;
        }

        public async Task<Despesa?> GetByIdAsync(Guid id)
        {
            return await _appDbContext.Despesas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Despesa>?> GetAllAsync()
        {
            return await _appDbContext.Despesas.ToListAsync();
        }
    }
}
