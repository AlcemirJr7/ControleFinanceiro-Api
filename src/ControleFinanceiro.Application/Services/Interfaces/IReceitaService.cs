using ControleFinanceiro.Application.DTOs;

namespace ControleFinanceiro.Application.Services.Interfaces
{
    public interface IReceitaService
    {
        Task<ReceitaDTO> CreateReceitaAsync(ReceitaDTO receitaDTO);
        Task<ReceitaDTO> UpdateReceitaAsync(ReceitaDTO receitaDTO);
        Task<ReceitaDTO> DeleteReceitaAsync(Guid receitaId);
    }
}
