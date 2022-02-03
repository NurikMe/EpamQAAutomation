using System;

namespace Task5.FlyableEntities
{
    class Bird : IFlyable
    {
        public Coordinate Position { get; private set; }

        private double speed;
        public Bird(Coordinate startPoint)
        {
            Position = startPoint;
            speed = new Random().NextDouble() * 20;
        }
        public void FlyTo(Coordinate arrivalPoint)
        {
            if (Position.Distance(arrivalPoint) >= 400)
            {
                throw new ArgumentOutOfRangeException("Distance must be less than 400");
            }
            Position = arrivalPoint;
        }
        public double GetFlyTime(Coordinate arrivalPoint)
        {
            if (Position.Distance(arrivalPoint) >= 400)
            {
                throw new ArgumentOutOfRangeException("Distance must be less than 400");
            }
            return Position.Distance(arrivalPoint) / speed * 60;
        }
    }
}
