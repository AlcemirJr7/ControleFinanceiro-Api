using AutoMapper;
using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Services.Interfaces;
using ControleFinanceiro.Application.Utils;
using ControleFinanceiro.Data.Repositories.Interfaces;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Application.Services
{
    public class ReceitaService : IReceitaService
    {
        private readonly IReceitaRepository _receitaRepository;
        private readonly IMapper _mapper;
        public ReceitaService(IReceitaRepository receitaRepository, IMapper mapper)
        {
            _receitaRepository = receitaRepository;
            _mapper = mapper;
        }

        public async Task<ReceitaDTO> CreateAsync(ReceitaDTO receitaDTO)
        {
            var receita = _mapper.Map<Receita>(receitaDTO);
            receita.SetDataCadastro(DateTimeUtil.GetDateTime());
            var result = await _receitaRepository.InsertAsync(receita);
            return _mapper.Map<ReceitaDTO>(result);
        }

        public async Task<ReceitaDTO> DeleteByIdAsync(Guid id)
        {
            var receita = await _receitaRepository.GetByIdAsync(id);
            if (receita is null) 
            {
                throw new Exception($"Id {id} not found.");
            }
            var result = await _receitaRepository.DeleteAsync(receita);
            return _mapper.Map<ReceitaDTO>(result);
        }

        public async Task<IEnumerable<ReceitaDTO>?> GetAllAsync()
        {
            var result = await _receitaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ReceitaDTO>>(result);
        }

        public async Task<ReceitaDTO?> GetByIdAsync(Guid id)
        {
            var result = await _receitaRepository.GetByIdAsync(id);
            return _mapper.Map<ReceitaDTO>(result);
        }

        public async Task<ReceitaDTO> UpdateAsync(ReceitaDTO receitaDTO)
        {
            var receita = _mapper.Map<Receita>(receitaDTO);
            var result = await _receitaRepository.UpdateAsync(receita);
            return _mapper.Map<ReceitaDTO>(result);
        }
    }
}
