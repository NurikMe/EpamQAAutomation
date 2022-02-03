using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.FlyableEntities
{
    class Airplane : IFlyable
    {
        public Coordinate Position { get; private set; }
        public Airplane(Coordinate startPoint)
        {
            Position = startPoint;
        }
        public void FlyTo(Coordinate arrivalPoint)
        {
            if (Position.Distance(arrivalPoint) < 10000)
            {
                Position = arrivalPoint;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Distance must be less than 10000");
            }
        }
        public double GetFlyTime(Coordinate arrivalPoint)
        {
            double distance = Position.Distance(arrivalPoint);
            double result = 0;
            double quotient = (int)((distance - 1) / 10);
            double remainder = distance % 10;
            result += remainder / (200 + quotient * 10);
            for (double i = quotient - 1; i >= 0; i--)
            {
                result += 10 / (200 + i * 10);
            }
            return result * 60;
        }
    }
}
