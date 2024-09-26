using System;

namespace CollectionsAndExceptions.Exceptions
{
    public class RemoveAutoException : VehicleException
    {
        public RemoveAutoException() : base() { }

        public RemoveAutoException(string message) : base(message) { }

        public RemoveAutoException(string message, Exception innerException) : base(message, innerException) { }
    }
}