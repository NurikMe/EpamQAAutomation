using System;

namespace CollectionsAndExceptions.Exceptions
{
    public class InitializationException : VehicleException
    {
        public InitializationException() : base() { }

        public InitializationException(string message) : base(message) { }

        public InitializationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
