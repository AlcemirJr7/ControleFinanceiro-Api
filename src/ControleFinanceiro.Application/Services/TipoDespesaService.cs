using AutoMapper;
using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Services.Interfaces;
using ControleFinanceiro.Application.Utils;
using ControleFinanceiro.Data.Repositories.Interfaces;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Application.Services
{
    public class TipoDespesaService : ITipoDespesaService
    {
        private readonly ITipoDespesaRepository _tipoDespesaRepository;
        private readonly IMapper _mapper;

        public TipoDespesaService(ITipoDespesaRepository tipoDespesaRepository, IMapper mapper)
        {
            _tipoDespesaRepository = tipoDespesaRepository;
            _mapper = mapper;
        }

        public async Task<TipoDespesaDTO> CreateAsync(TipoDespesaDTO tipoDespesaDTO)
        {
            var tipoDespesa = _mapper.Map<TipoDespesa>(tipoDespesaDTO);
            tipoDespesa.SetDataCadastro(DateTimeUtil.GetDateTime());
            var result = await _tipoDespesaRepository.InsertAsync(tipoDespesa);
            return _mapper.Map<TipoDespesaDTO>(result);
        }

        public async Task<TipoDespesaDTO> DeleteByIdAsync(Guid id)
        {
            var tipoDespesa = await _tipoDespesaRepository.GetByIdAsync(id);
            
            if (tipoDespesa is null) 
                throw new Exception($"Id {id} not found.");
            
            var result = await _tipoDespesaRepository.DeleteAsync(tipoDespesa);
            return _mapper.Map<TipoDespesaDTO>(result);
        }

        public async Task<IEnumerable<TipoDespesaDTO>?> GetAllAsync()
        {
            var result = await _tipoDespesaRepository.GetAll();
            return _mapper.Map<IEnumerable<TipoDespesaDTO>>(result);
        }

        public async Task<TipoDespesaDTO?> GetByIdAsync(Guid id)
        {
            var result = await _tipoDespesaRepository.GetByIdAsync(id);
            return _mapper.Map<TipoDespesaDTO>(result);
        }

        public async Task<TipoDespesaDTO> UpdateAsync(TipoDespesaDTO tipoDespesaDTO)
        {
            var tipoDespesa = _mapper.Map<TipoDespesa>(tipoDespesaDTO);
            var result = await _tipoDespesaRepository.UpdateAsync(tipoDespesa);
            return _mapper.Map<TipoDespesaDTO>(result);
        }
    }
}
