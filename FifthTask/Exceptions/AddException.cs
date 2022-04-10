using System;

namespace CollectionsAndExceptions.Exceptions
{
    public class AddException : VehicleException
    {
        public AddException() : base() { }

        public AddException(string message) : base(message) { }

        public AddException(string message, Exception innerException) : base(message, innerException) { }
    }
}