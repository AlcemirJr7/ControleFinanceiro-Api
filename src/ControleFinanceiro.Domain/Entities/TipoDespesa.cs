using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiro.Domain.Entities
{
    [Table("tb_tipo_despesa")]
    public class TipoDespesa
    {
        [Column("id")]
        public Guid Id { get; private set; }
        
        [Column("descricao")]
        public string Descricao { get; private set; } = string.Empty;

        [Column("data_cadastro")]
        public DateTime? DataCadastro { get; private set; }

        public TipoDespesa() {}

        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }

        public TipoDespesa(string descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            DataCadastro = DateTime.Now;
        }
        
    }
}
