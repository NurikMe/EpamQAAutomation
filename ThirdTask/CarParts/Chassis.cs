using System;
using System.Text;

namespace Task4.CarParts
{
    public class Chassis : AbstractPart
    {
        private int numberOfWheels;
        public int NumberOfWheels
        {
            get { return numberOfWheels; }
            set 
            {
                if (value > 0)
                {
                    numberOfWheels = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Number of Wheels must be more than 0");
                }; 
            }
        }

        private int serialNumber;
        public int SerialNumber
        {
            get { return serialNumber; }
            set 
            {
                if (value >= 0)
                {
                    serialNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Serial Number must be positive number");
                }; 
            }
        }

        private decimal permissibleLoad;
        public decimal PermissibleLoad
        {
            get { return permissibleLoad; }
            set 
            {
                if (value > 0)
                {
                    permissibleLoad = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Permissible Load must be more than 0");
                }; 
            }
        }

        public Chassis(int newNumberOfWheels, int newSerialNumber, decimal newPermissibleLoad)
        {
            NumberOfWheels = newNumberOfWheels;
            SerialNumber = newSerialNumber;
            PermissibleLoad = newPermissibleLoad;
        }
        protected override string Specification()
        {
            return String.Format($"Number of Wheels: {NumberOfWheels}\n\tTransmission Serial Number: {SerialNumber}\n\tPermissible Load: {PermissibleLoad}\n");
        } 
    }
}
