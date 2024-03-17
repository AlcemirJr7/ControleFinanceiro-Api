namespace ControleFinanceiro.Domain.Entities
{
    public class Receita
    {
        public Guid Id {  get; private set; }
        public Guid TipoReceitaId { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public decimal Valor { get; private set; } = 0;
        public DateTime DataReceita {  get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataAlteracao { get; private set; }

        public Receita(Guid tipoReceitaId, string nome, string descricao, decimal valor, DateTime dataReceita)
        {
            Id = Guid.NewGuid();
            TipoReceitaId = tipoReceitaId;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataReceita = dataReceita;
            DataCadastro = DateTime.Now;
        }

        public void Update(Guid tipoReceitaId, string nome, string descricao, decimal valor, DateTime dataReceita)
        {
            TipoReceitaId = tipoReceitaId;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataReceita = dataReceita;
            DataAlteracao = DateTime.Now;
        }

    }
}
