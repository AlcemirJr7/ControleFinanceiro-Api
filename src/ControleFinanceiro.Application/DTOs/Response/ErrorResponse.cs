namespace ControleFinanceiro.Application.DTOs.Response
{
    public class ErrorResponse
    {
        public IList<string> Errors { get; set; } = new List<string>();

        public ErrorResponse(IList<string> errors)
        {
            Errors = errors;
        }

        public ErrorResponse(string error)
        {
            Errors.Add(error);
        }
    }
}

