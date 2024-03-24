using AutoMapper;
using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Services.Interfaces;
using ControleFinanceiro.Application.Utils;
using ControleFinanceiro.Data.Repositories.Interfaces;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Application.Services
{
    public class TipoReceitaService : ITipoReceitaService
    {
        private readonly ITipoReceitaRepository _tipoReceitaRepository;
        private readonly IMapper _mapper;

        public TipoReceitaService(ITipoReceitaRepository tipoReceitaRepository, IMapper mapper)
        {
            _tipoReceitaRepository = tipoReceitaRepository;
            _mapper = mapper;
        }

        public async Task<TipoReceitaDTO> CreateAsync(TipoReceitaDTO tipoReceitaDTO)
        {
            var tipoReceita = _mapper.Map<TipoReceita>(tipoReceitaDTO);
            tipoReceita.SetDataCadastro(DateTimeUtil.GetDateTime());
            var result = await _tipoReceitaRepository.InsertAsync(tipoReceita);
            return _mapper.Map<TipoReceitaDTO>(result);
        }

        public async Task<TipoReceitaDTO> DeleteByIdAsync(Guid id)
        {
            var tipoReceita = await _tipoReceitaRepository.GetByIdAsync(id);
            if (tipoReceita is null) 
            {
                throw new Exception($"Id {id} not found.");
            }
            var result = await _tipoReceitaRepository.DeleteAsync(tipoReceita);
            return _mapper.Map<TipoReceitaDTO>(result);
        }

        public async Task<IEnumerable<TipoReceitaDTO>?> GetAllAsync()
        {
            var result = await _tipoReceitaRepository.GetAll();
            return _mapper.Map<IEnumerable<TipoReceitaDTO>>(result);
        }

        public async Task<TipoReceitaDTO?> GetByIdAsync(Guid id)
        {
            var result = await _tipoReceitaRepository.GetByIdAsync(id);
            return _mapper.Map<TipoReceitaDTO>(result);
        }

        public async Task<TipoReceitaDTO> UpdateAsync(TipoReceitaDTO tipoReceitaDTO)
        {
            var tipoReceita = _mapper.Map<TipoReceita>(tipoReceitaDTO);
            var result = await _tipoReceitaRepository.UpdateAsync(tipoReceita);
            return _mapper.Map<TipoReceitaDTO>(result);
        }
    }
}
