using Task4.CarParts;

namespace Task4.Transport
{
    public abstract class Vehicle
    {
        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
        public virtual Engine Engine { get; set; }

        public virtual Chassis Chassis { get; set; }

        public virtual Transmission Transmission { get; set; }

        protected abstract string Specification();
        public override string ToString()
        {
            return Specification();
        }
    }
}
