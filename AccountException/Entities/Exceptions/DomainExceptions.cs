using System;

namespace AccountException.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message)
            : base(message)
        {

        }
    }
}
