using System;
namespace ControleFinanceiro.Application.Exceptions
{
    [Serializable]
    public abstract class BaseException : Exception
    {
        public HashSet<string> Errors { get; private set; }

        public BaseException(HashSet<string> errors)
        {
            this.Errors = errors;
        }

        public BaseException(string message) : base(message) { }
        public BaseException(string message, Exception inner) : base(message, inner) { }
        protected BaseException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

