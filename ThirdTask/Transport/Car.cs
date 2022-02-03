using System;
using Task4.CarParts;

namespace Task4.Transport
{
    public class Car : Vehicle
    {
        public Car(Engine engine, Chassis chassis, Transmission transmission, BodyTypes newBodyType = BodyTypes.Coupe) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            BodyType = newBodyType;
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
                if ((value.EnginePower > 100 && value.EnginePower < 300) && (value.EngineVolume > 1.5m && value.EngineVolume < 4m))
                {
                    engine = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Car's Engine power between 100 & 300 and Engine volume between 1.5 & 4");
                }
            }
        }
        public BodyTypes BodyType
        { get; set; }

        protected override string Specification()
        {
            return $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{BodyType}";
        }
    }
}

