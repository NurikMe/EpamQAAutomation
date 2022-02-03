using System;
using System.Text;

namespace Task7.Car_Parts
{
    [Serializable]
    public class Chassis : Abstract_Part
    {
        public int NumberOfWheels { get; set; }

        public int SerialNumber { get; set; }

        public decimal PermissibleLoad { get; set; }

        private Chassis() { }
        public Chassis(int newNumberOfWheels, int newSerialNumber, decimal newPermissibleLoad)
        {
            NumberOfWheels = newNumberOfWheels;
            SerialNumber = newSerialNumber;
            PermissibleLoad = newPermissibleLoad;
        }
        protected override string Specification() => $"Number of Wheels: {NumberOfWheels}\n\tTransmission Serial Number: {SerialNumber}\n\tPermissible Load: {PermissibleLoad}\n";
    }
}
