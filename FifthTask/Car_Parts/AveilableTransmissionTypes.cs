namespace Task7.Car_Parts
{
    public enum AveilableTransmissionTypes
    {
        MechanicalGearbox,
        AutomaticGearbox,
        RoboticGearbox,
        VariableGearbox
    }
    class TransmissionTypes
    {
        public static string TransmissionType(AveilableTransmissionTypes type)
        {
            switch (type)
            {
                case AveilableTransmissionTypes.AutomaticGearbox:
                    return "Automatic Gearbox";
                    break;
                case AveilableTransmissionTypes.MechanicalGearbox:
                    return "Mechanical Gearbox";
                    break;
                case AveilableTransmissionTypes.RoboticGearbox:
                    return "Robotic Gearbox";
                    break;
                case AveilableTransmissionTypes.VariableGearbox:
                    return "Variable Gearbox";
                    break;
            }
            return "None of aveilable types";
        }
    }
}
