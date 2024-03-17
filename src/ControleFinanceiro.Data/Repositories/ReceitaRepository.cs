using ControleFinanceiro.Data.Context;
using ControleFinanceiro.Data.Repositories.Interfaces;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Data.Repositories
{
    public class ReceitaRepository : IReceitaRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReceitaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Receita> InsertAsync(Receita receita)
        {
            _appDbContext.Add(receita);
            await _appDbContext.SaveChangesAsync();
            return receita;
        }

        public async Task<Receita> DeleteAsync(Receita receita)
        {
            _appDbContext.Remove(receita);
            await _appDbContext.SaveChangesAsync();
            return receita;
        }

        public async Task<Receita> UpdateAsync(Receita receita)
        {
            _appDbContext.Update(receita);
            await _appDbContext.SaveChangesAsync();
            return receita;
        }
    }
}
