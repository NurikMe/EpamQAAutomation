using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.CarParts;

namespace Task4.Transport
{
    class Bus : Vehicle
    {
        public int Seats { get; set; }
        public Bus(Engine engine, Chassis chassis, Transmission transmission, int seats = 20) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Seats = seats;
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
                if ((value.EnginePower > 250 && value.EnginePower < 500) && (value.EngineVolume > 3m && value.EngineVolume < 6m))
                {
                    engine = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Car's Engine power between 250 & 500 and Engine volume between 3 & 6");
                }
            }
        }

        private Chassis chassis;
        public override Chassis Chassis { get; set; }

        private Transmission transmission;
        public override Transmission Transmission { get; set; }

        protected override string Specification()
        {
            return $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{Seats}";
        }
    }
}
