using System;
using System.Xml.Serialization;
using Task7.Car_Parts;

namespace Task7.Transport
{
    [Serializable]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Scooter))]
    public abstract class Vehicle
    {
        private Vehicle() { }

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
        public abstract Engine Engine { get; set; }

        public abstract Chassis Chassis { get; set; }

        public abstract Transmission Transmission { get; set; }

        protected abstract string Specification();
        public override string ToString()
        {
            return Specification();
        }
    }
}
