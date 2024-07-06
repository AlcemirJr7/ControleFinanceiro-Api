using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Application.DTOs
{
    public class TipoDespesaDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public string? DataCadastro { get; set; }

    }
}
