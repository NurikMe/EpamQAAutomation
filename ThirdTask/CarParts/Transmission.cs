using System;

namespace ThirdTask.CarParts
{
    public class Transmission : AbstractPart
    {
        private AveilableTransmissionTypes transmissionType;
        private int numberOfGears;
        private string producer;

        public AveilableTransmissionTypes TransmissionType
        {
            get { return transmissionType; }
            set
            {
                transmissionType = value;
            }
        }

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

        public Transmission(AveilableTransmissionTypes newTransmissionType, int newNumberOfGears, string newProducer)
        {
            TransmissionType = newTransmissionType;
            NumberOfGears = newNumberOfGears;
            Producer = newProducer;
        }

        protected override string Specification() => String.Format($"Transmission Type: {TransmissionType}\n\tNumber of Gears: {NumberOfGears}\n\tTransmission Producer: {Producer}\n");
    }
}
