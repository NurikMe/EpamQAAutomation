using System;
using Task4.CarParts;

namespace Task4.Transport
{
    class Scooter : Vehicle
    {
        public Scooter(Engine engine, Chassis chassis, Transmission transmission, AveilableColour newColour = AveilableColour.Black) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Colour = newColour;
        }
        private Engine engine;
        public override Engine Engine
        {
            get
            {
                return engine;
            }
            set
            {
                if ((value.EnginePower > 30 && value.EnginePower < 90) && (value.EngineVolume >= 0.5m && value.EngineVolume <= 1.5m))
                {
                    engine = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Car's Engine power between 30 & 90 and Engine volume between 0.5 & 1.5");
                }
            }
        }

        private Chassis chassis;
        public override Chassis Chassis { get; set; }

        private Transmission transmission;
        public override Transmission Transmission { get; set; }

        private AveilableColour colour;
        public AveilableColour Colour
        {
            get { return colour; }
            set
            {
                colour = value;
            }
        }

        protected override string Specification()
        {
            return $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{Colour}";
        }
    }
}
