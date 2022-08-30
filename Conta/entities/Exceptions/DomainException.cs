using System;

namespace Conta.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}