using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiro.Domain.Entities
{
    [Table("tb_receita")]
    public class Receita
    {
        [Column("id")]
        public Guid Id { get; private set; }

        [Column("tipo_receita_id")]
        public Guid TipoReceitaId { get; private set; }

        [Column("descricao")]
        public string Descricao { get; private set; } = string.Empty;

        [Column("valor")]
        public decimal Valor { get; private set; } = 0;
        
        [Column("data_receita")]
        public DateTime? DataReceita { get; private set; }
        
        [Column("data_cadastro")]        
        public DateTime? DataCadastro { get; private set; }
        
        [Column("data_alteracao")]
        public DateTime? DataAlteracao { get; private set; }

        public Receita() { }

        public Receita(Guid tipoReceitaId, string descricao, decimal valor, DateTime dataReceita)
        {
            Id = Guid.NewGuid();
            TipoReceitaId = tipoReceitaId;
            Descricao = descricao;
            Valor = valor;
            DataCadastro = DateTime.Now;
            DataReceita = dataReceita;
        }

        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }

        public void Update(Guid tipoReceitaId, string descricao, decimal valor, DateTime dataReceita)
        {
            TipoReceitaId = tipoReceitaId;
            Descricao = descricao;
            Valor = valor;
            DataReceita = dataReceita;
            DataAlteracao = DateTime.Now;
        }

    }
}
