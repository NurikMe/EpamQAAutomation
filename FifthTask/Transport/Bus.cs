using System;
using FifthTask.CarParts;

namespace FifthTask.Transport
{
    [Serializable]
    public class Bus : Vehicle
    {
        public int Seats { get; set; }

        public override Engine Engine { get; set; }

        public override Chassis Chassis { get; set; }

        public override Transmission Transmission { get; set; }
        
        private Bus() : base(null, null, null) { }
        
        public Bus(Engine engine, Chassis chassis, Transmission transmission, int seats = 20) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Seats = seats;
        }

        protected override string Specification() => $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{Seats}";
    }
}
