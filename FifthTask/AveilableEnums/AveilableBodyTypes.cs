namespace CollectionsAndExceptions.Transport
{
    class BodyTypes
    {
        public static string BodyType(AveilableBodyTypesEnum type)
        {
            switch (type)
            {
                case AveilableBodyTypesEnum.Coupe:
                    return "Coupe";
                case AveilableBodyTypesEnum.Hatchback:
                    return "Hatchback";
                case AveilableBodyTypesEnum.Sedan:
                    return "Sedan";
                case AveilableBodyTypesEnum.SportsCar:
                    return "Sports Car";
            }
            return "None of aveilable types";
        }
    }
}
