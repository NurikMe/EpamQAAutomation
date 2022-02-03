using System;


namespace Task4.CarParts
{
    public class Engine : AbstractPart
    {
        private decimal enginePower;
        public decimal EnginePower
        {
            get { return enginePower; }
            private set
            {
                if (value > 0)
                {
                    enginePower = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Engine Power must be more than 0");
                };
            }
        }

        private decimal engineVolume;
        public decimal EngineVolume
        {
            get { return engineVolume; }
            private set
            {
                if (value > 0)
                {
                    engineVolume = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Engine Volume must be more than 0");
                };
            }
        }

        private AveilableEngineTypes engineType;
        public AveilableEngineTypes EngineType
        {
            get { return engineType; }
            set
            {
                engineType = value;
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


        public Engine(decimal newEnginePower, decimal newEngineVolume, AveilableEngineTypes newEngineType, int newSerialNumber)
        {
            EnginePower = newEnginePower;
            EngineVolume = newEngineVolume;
            EngineType = newEngineType;
            SerialNumber = newSerialNumber;
        }
        protected override string Specification()
        {
            return String.Format($"Engine Power: {EnginePower}\n\tEngine Volume: {EngineVolume}\n\tEngine Type: {EngineType}\n\tSerial Number: {SerialNumber}\n");
        }
    }
}
