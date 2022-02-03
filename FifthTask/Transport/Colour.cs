
namespace Task7.Transport
{
    public enum AveilableColour
    {
        Red,
        Blue,
        Black,
        Green
    }
    class Colours
    {
        public static string Colour(AveilableColour type)
        {
            switch (type)
            {
                case AveilableColour.Black:
                    return "Black";
                    break;
                case AveilableColour.Blue:
                    return "Blue";
                    break;
                case AveilableColour.Green:
                    return "Green";
                    break;
                case AveilableColour.Red:
                    return "Red";
                    break;
            }
            return "None of aveilable colours";
        }
    }
}
