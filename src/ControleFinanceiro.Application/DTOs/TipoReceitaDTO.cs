using ControleFinanceiro.Domain.Enums;

namespace ControleFinanceiro.Application.DTOs
{
    public class TipoReceitaDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ETipoReceitaSituacao Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
