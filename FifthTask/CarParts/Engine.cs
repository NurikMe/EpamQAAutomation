using System;


namespace CollectionsAndExceptions.CarParts
{
    [Serializable]
    public class Engine : AbstractPart
    {
        public decimal EnginePower { get; set; }

        public decimal EngineVolume { get; set; }

        public AveilableEngineTypesEnum EngineType { get; set; }

        public int SerialNumber { get; set; }

        private Engine() { }

        public Engine(decimal newEnginePower, decimal newEngineVolume, AveilableEngineTypesEnum newEngineType, int newSerialNumber)
        {
            EnginePower = newEnginePower;
            EngineVolume = newEngineVolume;
            EngineType = newEngineType;
            SerialNumber = newSerialNumber;
        }

        protected override string Specification() => $"Engine Power: {EnginePower}\n\tEngine Volume: {EngineVolume}\n\tEngine Type: {EngineType}\n\tSerial Number: {SerialNumber}\n";
    }
}
