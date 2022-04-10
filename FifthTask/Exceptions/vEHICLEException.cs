using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndExceptions.Exceptions
{
    public class VehicleException : Exception
    {
        public VehicleException() { }

        public VehicleException(string message) : base(message) { }

        public VehicleException(string message, Exception innerException) : base(message, innerException) { }
    }
}
