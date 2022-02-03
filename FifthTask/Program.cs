using System.Collections.Generic;
using System.Linq;
using Task7.Car_Parts;
using Task7.Transport;
using System.Xml.Serialization;
using System.IO;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> Vehicles = new List<Vehicle>
            {
                new Car(new Engine(200m, 2m, AveilableEngineTypes.GasEngine, 12345)
                    , new Chassis(4, 32374, 320)
                    , new Transmission(AveilableTransmissionTypes.AutomaticGearbox,5,"Huawei")
                    ,AveilableBodyTypes.SportsCar),
                new Bus(new Engine(320m, 4m, AveilableEngineTypes.ElectricEngine, 954759)
                    , new Chassis(4, 659850, 600)
                    , new Transmission(AveilableTransmissionTypes.AutomaticGearbox,4,"Huawei")
                    ,16),
                new Scooter(new Engine(59m, 0.6m, AveilableEngineTypes.ElectricEngine, 573445)
                    , new Chassis(2, 45689384, 130)
                    , new Transmission(AveilableTransmissionTypes.AutomaticGearbox,3,"Huawei")
                    , AveilableColour.Blue),
                new Truck(new Engine(800m, 8m, AveilableEngineTypes.DieselEngine, 5894582)
                    , new Chassis(4, 985498, 1000)
                    , new Transmission(AveilableTransmissionTypes.MechanicalGearbox,5,"Huawei"),
                    250)
            };
            XmlSerializer formatter = new XmlSerializer(typeof(List<Vehicle>));
            using (FileStream filestream = new FileStream("vehicles_1.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(filestream, Vehicles.Where(vh => vh.Engine.EngineVolume > 1.5m).ToList());
            }
            using (FileStream filestream = new FileStream("vehicles_3.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(filestream, Vehicles.OrderBy(vh => vh.Transmission.TransmissionType).ToList());
            }
            formatter = new XmlSerializer(typeof(List<Engine>));
            using (FileStream filestream = new FileStream("vehicles_2.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(filestream, Vehicles.Where(vh => vh is Bus || vh is Truck)
                    .Select(vehicle => vehicle.Engine)
                    .ToList());
            }
            
        }
    }
}
