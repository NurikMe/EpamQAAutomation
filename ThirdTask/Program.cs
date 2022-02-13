﻿using System;
using ThirdTask.CarParts;
using ThirdTask.Transport;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new Engine(200m, 2m, AveilableEngineTypes.GasEngine, 12345)
                , new Chassis(4, 32374, 200)
                , new Transmission(AveilableTransmissionTypes.AutomaticGearbox,5,"Huawei")
                ,BodyTypes.SportsCar);
            Console.WriteLine(car);
        }
    }
}