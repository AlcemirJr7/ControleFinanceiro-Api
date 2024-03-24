using ControleFinanceiro.Application.DTOs;

namespace ControleFinanceiro.Application.Services.Interfaces
{
    public interface ITipoReceitaService
    {
        Task<TipoReceitaDTO?> GetByIdAsync(Guid id);
        Task<IEnumerable<TipoReceitaDTO>?> GetAllAsync();
        Task<TipoReceitaDTO> CreateAsync(TipoReceitaDTO tipoReceitaDTO);
        Task<TipoReceitaDTO> UpdateAsync(TipoReceitaDTO tipoReceitaDTO);
        Task<TipoReceitaDTO> DeleteByIdAsync(Guid id);

    }
}
