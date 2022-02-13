using System;
using FifthTask.CarParts;

namespace FifthTask.Transport
{
    [Serializable]
    public class Car : Vehicle
    {
        private AveilableBodyTypesEnum bodyType;

        public override Engine Engine { get; set; }

        public override Chassis Chassis { get; set; }

        public override Transmission Transmission { get; set; }

        public AveilableBodyTypesEnum BodyType
        {
            get { return bodyType; }
            set
            {
                bodyType = value;
            }
        }

        private Car() : base(null, null, null) { }

        public Car(Engine engine, Chassis chassis, Transmission transmission, AveilableBodyTypesEnum newBodyType = AveilableBodyTypesEnum.Coupe) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            BodyType = newBodyType;
        }

        protected override string Specification() => $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{BodyType}";
    }
}

