namespace FifthTask.CarParts
{
    class TransmissionTypes
    {
        public static string TransmissionType(AveilableTransmissionTypesEnum type)
        {
            switch (type)
            {
                case AveilableTransmissionTypesEnum.AutomaticGearbox:
                    return "Automatic Gearbox";
                case AveilableTransmissionTypesEnum.MechanicalGearbox:
                    return "Mechanical Gearbox";
                case AveilableTransmissionTypesEnum.RoboticGearbox:
                    return "Robotic Gearbox";
                case AveilableTransmissionTypesEnum.VariableGearbox:
                    return "Variable Gearbox";
            }
            return "None of aveilable types";
        }
    }
}
