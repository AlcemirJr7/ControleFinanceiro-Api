namespace ControleFinanceiro.Application.DTOs.Response
{
    public class OkResponse
    {
        public string Msg { get; set; } = string.Empty;

        public OkResponse() { }

        public OkResponse(string msg)
        {
            Msg = msg;
        }
    }
}
