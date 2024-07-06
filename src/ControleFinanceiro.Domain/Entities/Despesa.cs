using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiro.Domain.Entities
{
    [Table("tb_despesa")]
    public class Despesa
    {
        [Column("id")]
        public Guid Id { get; private set; }

        [Column("tipo_despesa_id")]
        public Guid TipoDespesaId { get; private set; }

        [Column("descricao")]
        public string Descricao { get; private set; } = string.Empty;

        [Column("valor")]
        public decimal Valor { get; private set; } = 0;
        
        [Column("data_despesa")]
        public DateTime? DataDespesa { get; private set; }
        
        [Column("data_cadastro")]        
        public DateTime? DataCadastro { get; private set; }
        
        [Column("data_alteracao")]
        public DateTime? DataAlteracao { get; private set; }

        public Despesa() { }

        public Despesa(Guid tipoDespesaId, string descricao, decimal valor, DateTime dataDespesa)
        {
            Id = Guid.NewGuid();
            TipoDespesaId = tipoDespesaId;
            Descricao = descricao;
            Valor = valor;
            DataCadastro = DateTime.Now;
            DataDespesa = dataDespesa;
        }

        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }

        public void Update(Guid tipoDespesaId, string descricao, decimal valor, DateTime dataDespesa)
        {
            TipoDespesaId = tipoDespesaId;
            Descricao = descricao;
            Valor = valor;
            DataDespesa = dataDespesa;
            DataAlteracao = DateTime.Now;
        }

    }
}
