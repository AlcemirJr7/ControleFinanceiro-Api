using ControleFinanceiro.Data.Context;
using ControleFinanceiro.Data.Repositories.Interfaces;
using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Data.Repositories
{
    public class TipoReceitaRepository : ITipoReceitaRepository
    {
        private readonly AppDbContext _appDbContext;
        public TipoReceitaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<TipoReceita> DeleteAsync(TipoReceita tipoReceita)
        {
            _appDbContext.Remove(tipoReceita);
            await _appDbContext.SaveChangesAsync();
            return tipoReceita;
        }

        public async Task<IEnumerable<TipoReceita>?> GetAll()
        {
            return await _appDbContext.TipoReceitas.ToListAsync();
        }

        public async Task<TipoReceita?> GetByIdAsync(Guid id)
        {
            return await _appDbContext.TipoReceitas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TipoReceita> InsertAsync(TipoReceita tipoReceita)
        {
            _appDbContext.Add(tipoReceita);
            await _appDbContext.SaveChangesAsync();
            return tipoReceita;
        }

        public async Task<TipoReceita> UpdateAsync(TipoReceita tipoReceita)
        {
            _appDbContext.Update(tipoReceita);
            await _appDbContext.SaveChangesAsync();
            return tipoReceita;
        }
    }
}
