using System;
using CollectionsAndExceptions.CarParts;

namespace CollectionsAndExceptions.Transport
{
    [Serializable]
    public class Truck : Vehicle
    {
        public decimal CargoVolume { get; set; }

        public override Engine Engine { get; set; }

        public override Chassis Chassis { get; set; }

        public override Transmission Transmission { get; set; }

        private Truck() : base(null, null, null) { }

        public Truck(Engine engine, Chassis chassis, Transmission transmission, decimal cargoVolume = 40) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            CargoVolume = cargoVolume;
        }

        protected override string Specification() => $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{CargoVolume}";
    }
}
