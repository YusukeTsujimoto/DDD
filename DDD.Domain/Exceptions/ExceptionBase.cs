using System;

namespace Ddd.Domain.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        protected ExceptionBase(ExceptionType exceptionType, string message)
            : base(message)
        {
            ExceptionType = exceptionType;
        }

        public ExceptionType ExceptionType { get; }
    }
}
