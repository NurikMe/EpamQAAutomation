using System;
using ThirdTask.CarParts;

namespace ThirdTask.Transport
{
    class Scooter : Vehicle
    {
        private Engine engine;
        private AveilableColour colour;

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

        public override Chassis Chassis { get; set; }

        public override Transmission Transmission { get; set; }

        public AveilableColour Colour
        {
            get { return colour; }
            set
            {
                colour = value;
            }
        }

        public Scooter(Engine engine, Chassis chassis, Transmission transmission, AveilableColour newColour = AveilableColour.Black) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Colour = newColour;
        }

        protected override string Specification() => $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{Colour}";
    }
}
