namespace Task7.Car_Parts
{
    public enum AveilableEngineTypes
    {
        SteamEngine,
        GasEngine,
        DieselEngine,
        NaturalGasEngine,
        ElectricEngine,
    }
    class EngineTypes
    {
        public static string EngineType(AveilableEngineTypes type)
        {
            switch (type)
            {
                case AveilableEngineTypes.DieselEngine:
                    return "Diesel Engine";
                    break;
                case AveilableEngineTypes.ElectricEngine:
                    return "Electric Engine";
                    break;
                case AveilableEngineTypes.GasEngine:
                    return "Gas Engine";
                    break;
                case AveilableEngineTypes.NaturalGasEngine:
                    return "Natural Gas Engine";
                    break;
                case AveilableEngineTypes.SteamEngine:
                    return "Steam Engine";
                    break;
            }
            return "None of aveilable types";
        }
    }
}
