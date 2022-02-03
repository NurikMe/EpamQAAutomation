using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Car_Parts
{
    [Serializable]
    public class Transmission : Abstract_Part
    {
        private Transmission() { }
        public Transmission(AveilableTransmissionTypes newTransmissionType, int newNumberOfGears, string newProducer)
        {
            TransmissionType = newTransmissionType;
            NumberOfGears = newNumberOfGears;
            Producer = newProducer;
        }

        public AveilableTransmissionTypes TransmissionType { get; set; }

        public int NumberOfGears { get; set; }

        public string Producer { get; set; }

        protected override string Specification() => $"Transmission Type: {TransmissionType}\n\tNumber of Gears: {NumberOfGears}\n\tTransmission Producer: {Producer}\n";
    }
}
