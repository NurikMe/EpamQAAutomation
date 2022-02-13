using System;

namespace Task5.FlyableEntities
{
    public struct Coordinate
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set 
            {
                if (value > 0)
                {
                    x = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Coordinate must be positive");
                }
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value > 0)
                {
                    y = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Coordinate must be positive");
                }
            }
        }

        public int Z
        {
            get { return z; }
            set
            {
                if (value > 0)
                {
                    z = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Coordinate must be positive");
                }
            }
        }

        public Coordinate(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Distance(Coordinate arrivalPoint)
        {
            double result = Math.Sqrt(Math.Pow(X - arrivalPoint.X, 2) + Math.Pow(Y - arrivalPoint.Y, 2) + Math.Pow(Z - arrivalPoint.Z, 2));
            return result;
        }
    }
}
