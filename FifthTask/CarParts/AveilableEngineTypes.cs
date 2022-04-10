namespace CollectionsAndExceptions.CarParts
{
    class EngineTypes
    {
        public static string EngineType(AveilableEngineTypesEnum type)
        {
            switch (type)
            {
                case AveilableEngineTypesEnum.DieselEngine:
                    return "Diesel Engine";
                case AveilableEngineTypesEnum.ElectricEngine:
                    return "Electric Engine";
                case AveilableEngineTypesEnum.GasEngine:
                    return "Gas Engine";
                case AveilableEngineTypesEnum.NaturalGasEngine:
                    return "Natural Gas Engine";
                case AveilableEngineTypesEnum.SteamEngine:
                    return "Steam Engine";
            }
            return "None of aveilable types";
        }
    }
}
