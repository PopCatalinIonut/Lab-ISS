using System;

namespace service
{
    public class ServiceException : ApplicationException
    {
        public ServiceException(String message) : base(message) { }
    }
}