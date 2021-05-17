using System;

namespace domain.validator
{
    public class ValidationException : ApplicationException
    {
        public ValidationException(String message) : base(message) {
        }
    }
}