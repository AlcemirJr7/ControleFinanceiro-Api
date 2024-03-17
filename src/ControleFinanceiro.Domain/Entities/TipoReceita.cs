using ControleFinanceiro.Domain.Enums;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoReceita
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public ETipoReceitaSituacao Situacao {  get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataAlteracao { get; private set; }

        public TipoReceita() { }

        public TipoReceita(string descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Situacao = ETipoReceitaSituacao.Ativo;
            DataCadastro = DateTime.Now;
        }

        public TipoReceita(string descricao, ETipoReceitaSituacao situacao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Situacao = situacao;
            DataCadastro = DateTime.Now;
        }

        public void Update(string descricao, ETipoReceitaSituacao situacao)
        {
            Descricao = descricao;
            Situacao = situacao;
            DataAlteracao = DateTime.Now;
        }
        
    }
}
