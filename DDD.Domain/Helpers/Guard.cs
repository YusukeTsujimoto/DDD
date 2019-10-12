using Ddd.Domain.Exceptions;

namespace Ddd.Domain.Helpers
{
    public static class Guard
    {
        public static void IsNullOrEmptyMessage(string value, string message)
        {
            IsNullOrEmptyMessage(value, message, ExceptionType.Information);
        }

        public static void IsNullOrEmptyMessage(string value, string message, ExceptionType exceptionType)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new MessageException(exceptionType, message);
            }
        }
    }
}
