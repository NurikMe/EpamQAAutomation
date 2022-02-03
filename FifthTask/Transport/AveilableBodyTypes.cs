namespace Task7.Transport
{
    public enum AveilableBodyTypes
    {
        Sedan,
        Coupe,
        SportsCar,
        Hatchback,
    };
    class BodyTypes
    {
        public static string BodyType(AveilableBodyTypes type)
        {
            switch (type)
            {
                case AveilableBodyTypes.Coupe:
                    return "Coupe";
                    break;
                case AveilableBodyTypes.Hatchback:
                    return "Hatchback";
                    break;
                case AveilableBodyTypes.Sedan:
                    return "Sedan";
                    break;
                case AveilableBodyTypes.SportsCar:
                    return "Sports Car";
                    break;
            }
            return "None of aveilable types";
        }
    }
}
