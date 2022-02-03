using System;


namespace Task7.Car_Parts
{
    [Serializable]
    public class Engine : Abstract_Part
    {
        public decimal EnginePower { get; set; }

        public decimal EngineVolume { get; set; }

        public AveilableEngineTypes EngineType { get; set; }

        public int SerialNumber { get; set; }

        private Engine() { }
        public Engine(decimal newEnginePower, decimal newEngineVolume, AveilableEngineTypes newEngineType, int newSerialNumber)
        {
            EnginePower = newEnginePower;
            EngineVolume = newEngineVolume;
            EngineType = newEngineType;
            SerialNumber = newSerialNumber;
        }
        protected override string Specification() => $"Engine Power: {EnginePower}\n\tEngine Volume: {EngineVolume}\n\tEngine Type: {EngineType}\n\tSerial Number: {SerialNumber}\n";
    }
}
