using System;
using Task5.FlyableEntities;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate startPoint = new Coordinate(0,10,5);
            Coordinate endPoint = new Coordinate(20,10,25);
            
            Bird testBird = new Bird(startPoint);
            Airplane testAirplane = new Airplane(startPoint);
            Drone testDrone = new Drone(startPoint, 25);
            
            Console.WriteLine(testBird.GetFlyTime(endPoint));
            testBird.FlyTo(endPoint);
            Console.WriteLine(testBird.GetFlyTime(endPoint));
            
            Console.WriteLine(testAirplane.GetFlyTime(endPoint));
            testAirplane.FlyTo(endPoint);
            Console.WriteLine(testAirplane.GetFlyTime(endPoint));
            
            Console.WriteLine(testDrone.GetFlyTime(endPoint));
            testDrone.FlyTo(endPoint);
            Console.WriteLine(testDrone.GetFlyTime(endPoint));
        }
    }
}
