using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.CarParts;

namespace ThirdTask.Transport
{
    class Truck : Vehicle
    {
        public decimal CargoVolume { get; set; }
        public Truck(Engine engine, Chassis chassis, Transmission transmission, decimal cargoVolume = 40) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            CargoVolume = cargoVolume;
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

        private Chassis chassis;
        public override Chassis Chassis { get; set; }

        private Transmission transmission;
        public override Transmission Transmission { get; set; }

        protected override string Specification()
        {
            return $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{CargoVolume}";
        }
    }
}
