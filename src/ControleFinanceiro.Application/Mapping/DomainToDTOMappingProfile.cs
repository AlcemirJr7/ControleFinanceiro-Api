using AutoMapper;
using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Application.Mapping
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Receita, ReceitaDTO>().ReverseMap();
            CreateMap<TipoReceita, TipoReceitaDTO>().ReverseMap();
        }
    }
}
