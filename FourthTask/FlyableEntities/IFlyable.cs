using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.FlyableEntities
{
    interface IFlyable
    {
        /// <summary>
        /// Sets new position for object.
        /// </summary>
        /// <param name="point"></param>
        public void FlyTo(Coordinate point);
        /// <summary>
        /// Calculates flight time to a new position.
        /// </summary>
        /// <param name="arrivalPoint"></param>
        /// <returns>Fly Time in minutes</returns>
        public double GetFlyTime(Coordinate arrivalPoint);
    }
}
