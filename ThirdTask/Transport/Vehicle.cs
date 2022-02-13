using ThirdTask.CarParts;

namespace ThirdTask.Transport
{
    public abstract class Vehicle
    {
        public virtual Engine Engine { get; set; }

        public virtual Chassis Chassis { get; set; }

        public virtual Transmission Transmission { get; set; }

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        protected abstract string Specification();

        public override string ToString() => Specification();
    }
}
