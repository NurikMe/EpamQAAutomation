using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int.TryParse(args[0], out int number);
                int.TryParse(args[1], out int newBasis);

                NumberSystemConverter Converter = new NumberSystemConverter();
                string result = Converter.BasisConverter(number, newBasis);
                Console.WriteLine(result);

            }
        }
    }
}
