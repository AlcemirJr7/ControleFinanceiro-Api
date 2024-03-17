using AutoMapper;
using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Services.Interfaces;
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

        public async Task<ReceitaDTO> CreateReceitaAsync(ReceitaDTO receitaDTO)
        {
            var receita = _mapper.Map<Receita>(receitaDTO);
            var result = await _receitaRepository.InsertAsync(receita);
            return _mapper.Map<ReceitaDTO>(receita);
        }

        public Task<ReceitaDTO> DeleteReceitaAsync(Guid receitaId)
        {
            throw new NotImplementedException();
        }

        public async Task<ReceitaDTO> UpdateReceitaAsync(ReceitaDTO receitaDTO)
        {
            var receita = _mapper.Map<Receita>(receitaDTO);
            var result = await _receitaRepository.UpdateAsync(receita);
            return _mapper.Map<ReceitaDTO>(receita);
        }
    }
}
