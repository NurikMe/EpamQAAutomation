using System;
using Task7.Car_Parts;

namespace Task7.Transport
{
    [Serializable]
    public class Car : Vehicle
    {
        private AveilableBodyTypes bodyType;

        public override Engine Engine { get; set; }

        public override Chassis Chassis { get; set; }

        public override Transmission Transmission { get; set; }

        public AveilableBodyTypes BodyType
        {
            get { return bodyType; }
            set
            {
                bodyType = value;
            }
        }

        private Car() : base(null, null, null) { }

        public Car(Engine engine, Chassis chassis, Transmission transmission, AveilableBodyTypes newBodyType = AveilableBodyTypes.Coupe) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            BodyType = newBodyType;
        }

        protected override string Specification() => $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{BodyType}";
    }
}

