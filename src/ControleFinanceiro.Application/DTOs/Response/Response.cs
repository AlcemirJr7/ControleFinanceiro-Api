namespace ControleFinanceiro.Application.DTOs.Response
{
    public sealed class Response
    {
        public OkResponse? OkResponse { get; set; } = null;
        public ErrorResponse? ErrorResponse { get; set; } = null;

        public Response() { }

        public Response(ErrorResponse errorResponse)
        {
            ErrorResponse = errorResponse;
        }

        public Response(OkResponse okResponse)
        {
            OkResponse = okResponse;
        }
    }
}
