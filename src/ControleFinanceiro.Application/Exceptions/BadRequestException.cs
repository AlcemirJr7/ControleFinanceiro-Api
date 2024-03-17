using System.Runtime.Serialization;

namespace ControleFinanceiro.Application.Exceptions
{
    [Serializable]
    public class BadRequestException : BaseException
    {
        public BadRequestException(HashSet<string> errors) : base(errors)
        {
        }

        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(string message, Exception inner) : base(message, inner)
        {
        }

        public BadRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
