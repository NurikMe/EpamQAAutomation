using System;
using Task7.Car_Parts;

namespace Task7.Transport
{
    [Serializable]
    public class Scooter : Vehicle
    {

        private AveilableColour colour;

        public override Engine Engine { get; set; }

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

        private Scooter() : base(null, null, null) { }

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
