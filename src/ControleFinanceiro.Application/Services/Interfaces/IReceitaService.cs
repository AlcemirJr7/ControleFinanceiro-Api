using ControleFinanceiro.Application.DTOs;

namespace ControleFinanceiro.Application.Services.Interfaces
{
    public interface IReceitaService
    {
        Task<ReceitaDTO?> GetByIdAsync(Guid id);
        Task<IEnumerable<ReceitaDTO>?> GetAllAsync();
        Task<ReceitaDTO> CreateAsync(ReceitaDTO receitaDTO);
        Task<ReceitaDTO> UpdateAsync(ReceitaDTO receitaDTO);
        Task<ReceitaDTO> DeleteByIdAsync(Guid id);
    }
}
