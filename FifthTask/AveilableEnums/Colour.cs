
namespace CollectionsAndExceptions.Transport
{
    class Colours
    {
        public static string Colour(AveilableColourEnum type)
        {
            switch (type)
            {
                case AveilableColourEnum.Black:
                    return "Black";
                case AveilableColourEnum.Blue:
                    return "Blue";
                case AveilableColourEnum.Green:
                    return "Green";
                case AveilableColourEnum.Red:
                    return "Red";
            }
            return "None of aveilable colours";
        }
    }
}
