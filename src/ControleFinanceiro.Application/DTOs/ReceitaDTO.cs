using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Application.DTOs
{
    public class ReceitaDTO
    {
        public Guid Id { get; set; }
        public Guid TipoReceitaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; } = 0;
        public DateTime DataReceita { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
