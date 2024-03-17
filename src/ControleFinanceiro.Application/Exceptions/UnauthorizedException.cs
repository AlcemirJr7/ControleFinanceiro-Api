using System;
using System.Runtime.Serialization;

namespace ControleFinanceiro.Application.Exceptions
{
    [Serializable]
    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(HashSet<string> errors) : base(errors)
        {
        }

        public UnauthorizedException(string message) : base(message)
        {
        }

        public UnauthorizedException(string message, Exception inner) : base(message, inner)
        {
        }

        public UnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

