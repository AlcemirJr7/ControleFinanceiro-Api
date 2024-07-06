using ControleFinanceiro.Application.DTOs;

namespace ControleFinanceiro.Application.Services.Interfaces
{
    public interface ITipoDespesaService
    {
        Task<TipoDespesaDTO?> GetByIdAsync(Guid id);
        Task<IEnumerable<TipoDespesaDTO>?> GetAllAsync();
        Task<TipoDespesaDTO> CreateAsync(TipoDespesaDTO tipoDespesaDTO);
        Task<TipoDespesaDTO> UpdateAsync(TipoDespesaDTO tipoDespesaDTO);
        Task<TipoDespesaDTO> DeleteByIdAsync(Guid id);

    }
}
