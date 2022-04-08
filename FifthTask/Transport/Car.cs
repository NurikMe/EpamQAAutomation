using System;
using FifthTask.Exceptions;
using FifthTask.CarParts;

namespace FifthTask.Transport
{
    [Serializable]
    public class Car : Vehicle
    {
        private string[] Parameters = { "EngineSerialNumber", "ChassisSerialNumber",
            "TransmissionProducer", "BodyType" };

        private AveilableBodyTypesEnum bodyType;

        public override Engine Engine { get; set; }

        public override Chassis Chassis { get; set; }

        public override Transmission Transmission { get; set; }

        public AveilableBodyTypesEnum BodyType
        {
            get { return bodyType; }
            set
            {
                bodyType = value;
            }
        }

        private Car() : base(null, null, null) { }

        public Car(Engine engine, Chassis chassis, Transmission transmission,
            AveilableBodyTypesEnum newBodyType = AveilableBodyTypesEnum.Coupe) : base(engine, chassis, transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            BodyType = newBodyType;
        }

        protected override string Specification() => $"Car:\n\t{Engine}\n\t{Chassis}\n\t{Transmission}\n\t{BodyType}";

        delegate string Message();

        /// <summary>
        /// Gets auto by valid parameter
        /// </summary>
        /// <param name="parameter"> Valid params: EngineSerialNumber, ChassisSerialNumber, 
        /// Transmission, BodyType </param>
        /// <param name="value"> Valid values: EngineSerialNumber - integer; ChassisSerialNumber - integer; 
        /// TransmissionProducer - Huawei, Samsung, Tesla; BodyType - Sedan, Coupe, SportsCar, Hatchback </param>
        /// <returns></returns>
        protected override Car GetAutoByParameter(string parameter, string value)
        {

            for(int i = 0; i < 3; i++)
            {

            }
            throw new GetAutoByParameterException("");
        }
    }
}

