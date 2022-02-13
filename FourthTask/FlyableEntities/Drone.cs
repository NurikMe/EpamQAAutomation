using System;

namespace Task5.FlyableEntities
{
    public class Drone : IFlyable
    {
        public Coordinate Position { get; private set; }

        public double Speed { get; private set; }

        public Drone(Coordinate startPoint, double speed)
        {
            Speed = speed;
            Position = startPoint;
        }

        public void FlyTo(Coordinate arrivalPoint)
        {
            if (Position.Distance(arrivalPoint) >= 1000)
            {
                throw new ArgumentOutOfRangeException("Distance must be less than 1000");
            }
            Position = arrivalPoint;
        }

        public double GetFlyTime(Coordinate arrivalPoint)
        {
            double distance = Position.Distance(arrivalPoint);
            double result = 0;
            double stopTime = (int)(distance / Speed * 6);
            result += distance / Speed * 60 + stopTime;
            return result;
        }
    }
}
