using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask.CarParts
{
    [Serializable]
    public class Transmission : AbstractPart
    {
        public AveilableTransmissionTypesEnum TransmissionType { get; set; }

        public int NumberOfGears { get; set; }

        public string Producer { get; set; }

        private Transmission() { }

        public Transmission(AveilableTransmissionTypesEnum newTransmissionType, int newNumberOfGears, string newProducer)
        {
            TransmissionType = newTransmissionType;
            NumberOfGears = newNumberOfGears;
            Producer = newProducer;
        }

        protected override string Specification() => $"Transmission Type: {TransmissionType}\n\tNumber of Gears: {NumberOfGears}\n\tTransmission Producer: {Producer}\n";
    }
}
