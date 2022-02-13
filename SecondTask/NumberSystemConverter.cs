using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class NumberSystemConverter
    {
        const int minimumBasis = 2;
        const int maximumBasis = 20;
        public string BasisConverter(int number, int newBasis)
        {
            try
            {
                bool negative = false;
                StringBuilder numberInNewBasis = new StringBuilder();

                if (newBasis < minimumBasis || newBasis > maximumBasis)
                {
                    throw new Exception("New Basis must be less than 20 and bigger than 2");
                }

                if(number < 0)
                {
                    negative = true;
                    number = Math.Abs(number);
                }

                while (number != 0)
                {
                    int remainder = number % newBasis;
                    if (remainder < 10)
                    {
                        numberInNewBasis.Append(remainder);
                    }
                    else
                    {
                        numberInNewBasis.Append((char)(55 + remainder)); //65 in ASCII table is symbol`s A code
                    }
                    number /= newBasis;
                }

                if (negative)
                {
                    numberInNewBasis.Append('-');
                }

                return new string (numberInNewBasis.ToString().Reverse().ToArray());
            }
            catch (Exception exception)
            {
                return exception.Message.ToString();
            }
        }
    }
}
