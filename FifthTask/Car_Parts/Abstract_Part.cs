using System;
using System.Xml.Serialization;

namespace Task7.Car_Parts
{
    [Serializable]
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Transmission))]
    public abstract class Abstract_Part
    {
        protected abstract string Specification();
        public override string ToString()
        {
            return Specification();
        }
    }
}
