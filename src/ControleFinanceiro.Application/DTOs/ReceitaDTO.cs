using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Application.DTOs
{
    public class ReceitaDTO
    {
        public Guid Id { get; set; }
        public Guid TipoReceitaId { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; } = 0;
        
        [DataType(DataType.DateTime)]
        public string? DataReceita { get; set; }
        [DataType(DataType.DateTime)]
        public string? DataCadastro { get; set; }
        [DataType(DataType.DateTime)]
        public string? DataAlteracao { get; set; }

    }
}
