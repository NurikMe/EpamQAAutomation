using System;

namespace CollectionsAndExceptions.Exceptions
{
    public class UpdateAutoException : VehicleException
    {
        public UpdateAutoException() : base() { }

        public UpdateAutoException(string message) : base(message) { }

        public UpdateAutoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
