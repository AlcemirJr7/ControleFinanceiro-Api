using ControleFinanceiro.Application.DTOs;

namespace ControleFinanceiro.Application.Services.Interfaces
{
    public interface IDespesaService
    {
        Task<DespesaDTO?> GetByIdAsync(Guid id);
        Task<IEnumerable<DespesaDTO>?> GetAllAsync();
        Task<DespesaDTO> CreateAsync(DespesaDTO despesaDTO);
        Task<DespesaDTO> UpdateAsync(DespesaDTO despesaDTO);
        Task<DespesaDTO> DeleteByIdAsync(Guid id);
    }
}
