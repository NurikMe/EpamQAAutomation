using System;

namespace Task4.CarParts
{
    public class Transmission : AbstractPart
    {
        public Transmission(AveilableTransmissionTypes newTransmissionType, int newNumberOfGears, string newProducer)
        {
            TransmissionType = newTransmissionType;
            NumberOfGears = newNumberOfGears;
            Producer = newProducer;
        }

        private AveilableTransmissionTypes transmissionType;
        public AveilableTransmissionTypes TransmissionType
        {
            get { return transmissionType; }
            set
            {
                transmissionType = value;
            }
        }

        private int numberOfGears;
        public int NumberOfGears
        {
            get { return numberOfGears; }
            set
            {
                if (value > 0)
                {
                    numberOfGears = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Number of Gears must be more than 0");
                };
            }
        }

        private string producer;
        public string Producer
        {
            get { return producer; }
            set
            {
                if (value.Length > 0)
                {
                    producer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Producer's name must be longer than 0");
                };
            }
        }

        protected override string Specification()
        {
            return String.Format($"Transmission Type: {TransmissionType}\n\tNumber of Gears: {NumberOfGears}\n\tTransmission Producer: {Producer}\n");
        }
    }
}
