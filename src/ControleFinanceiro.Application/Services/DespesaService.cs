using AutoMapper;
using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Services.Interfaces;
using ControleFinanceiro.Application.Utils;
using ControleFinanceiro.Data.Repositories.Interfaces;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Application.Services
{
    public class DespesaService : IDespesaService
    {
        private readonly IDespesaRepository _despesaRepository;
        private readonly IMapper _mapper;
        public DespesaService(IDespesaRepository despesaRepository, IMapper mapper)
        {
            _despesaRepository = despesaRepository;
            _mapper = mapper;
        }

        public async Task<DespesaDTO> CreateAsync(DespesaDTO despesaDTO)
        {
            var despesa = _mapper.Map<Despesa>(despesaDTO);
            despesa.SetDataCadastro(DateTimeUtil.GetDateTime());
            var result = await _despesaRepository.InsertAsync(despesa);
            return _mapper.Map<DespesaDTO>(result);
        }

        public async Task<DespesaDTO> DeleteByIdAsync(Guid id)
        {
            var despesa = await _despesaRepository.GetByIdAsync(id);

            if (despesa is null)
                throw new Exception($"Id {id} not found.");
            
            var result = await _despesaRepository.DeleteAsync(despesa);
            return _mapper.Map<DespesaDTO>(result);
        }

        public async Task<IEnumerable<DespesaDTO>?> GetAllAsync()
        {
            var result = await _despesaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DespesaDTO>>(result);
        }

        public async Task<DespesaDTO?> GetByIdAsync(Guid id)
        {
            var result = await _despesaRepository.GetByIdAsync(id);
            return _mapper.Map<DespesaDTO>(result);
        }

        public async Task<DespesaDTO> UpdateAsync(DespesaDTO despesaDTO)
        {
            var despesa = _mapper.Map<Despesa>(despesaDTO);
            var result = await _despesaRepository.UpdateAsync(despesa);
            return _mapper.Map<DespesaDTO>(result);
        }
    }
}
