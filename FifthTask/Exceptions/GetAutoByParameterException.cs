using System;

namespace CollectionsAndExceptions.Exceptions
{
    public class GetAutoByParameterException : VehicleException
    {
        public GetAutoByParameterException() : base() { }

        public GetAutoByParameterException(string message) : base(message) { }

        public GetAutoByParameterException(string message, Exception innerException) : base(message, innerException) { }
    }
}
