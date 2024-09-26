using System.Collections.Generic;
using System.Linq;
using CollectionsAndExceptions.CarParts;
using CollectionsAndExceptions.Transport;
using System.Xml.Serialization;
using System.IO;
using CollectionsAndExceptions.Exceptions;

namespace CollectionsAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Vehicle> Vehicles = new List<Vehicle>
            //{
            //    new Car(new Engine(200m, 2m, AveilableEngineTypesEnum.GasEngine, 12345)
            //        , new Chassis(4, 32374, 320)
            //        , new Transmission(AveilableTransmissionTypesEnum.AutomaticGearbox,5,"Huawei")
            //        ,AveilableBodyTypesEnum.SportsCar),
            //    new Bus(new Engine(320m, 4m, AveilableEngineTypesEnum.ElectricEngine, 954759)
            //        , new Chassis(4, 659850, 600)
            //        , new Transmission(AveilableTransmissionTypesEnum.AutomaticGearbox,4,"Huawei")
            //        ,16),
            //    new Scooter(new Engine(59m, 0.6m, AveilableEngineTypesEnum.ElectricEngine, 573445)
            //        , new Chassis(2, 45689384, 130)
            //        , new Transmission(AveilableTransmissionTypesEnum.AutomaticGearbox,3,"Huawei")
            //        , AveilableColourEnum.Blue),
            //    new Truck(new Engine(800m, 8m, AveilableEngineTypesEnum.DieselEngine, 5894582)
            //        , new Chassis(4, 985498, 1000)
            //        , new Transmission(AveilableTransmissionTypesEnum.MechanicalGearbox,5,"Huawei"),
            //        250)
            //};
            //XmlSerializer formatter = new XmlSerializer(typeof(List<Vehicle>));
            //using (FileStream filestream = new FileStream("vehicles_1.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(filestream, Vehicles.Where(vh => vh.Engine.EngineVolume > 1.5m).ToList());
            //}
            //using (FileStream filestream = new FileStream("vehicles_3.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(filestream, Vehicles.OrderBy(vh => vh.Transmission.TransmissionType).ToList());
            //}
            //formatter = new XmlSerializer(typeof(List<Engine>));
            //using (FileStream filestream = new FileStream("vehicles_2.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(filestream, Vehicles.Where(vh => vh is Bus || vh is Truck)
            //        .Select(vehicle => vehicle.Engine)
            //        .ToList());
            //}
            try
            {
                VehiclePark vehiclePark = new VehiclePark(1,
                    new Car(
                        new Engine(200m, 2m, AveilableEngineTypesEnum.GasEngine, 12345),
                        new Chassis(4, 32374, 320),
                        new Transmission(AveilableTransmissionTypesEnum.AutomaticGearbox, 5, "Huawei"),
                        AveilableBodyTypesEnum.SportsCar));

                var bus = new Bus(
                       new Engine(320m, 4m, AveilableEngineTypesEnum.ElectricEngine, 954759),
                       new Chassis(4, 659850, 600),
                       new Transmission(AveilableTransmissionTypesEnum.AutomaticGearbox, 4, "Huawei"),
                       16);
                vehiclePark.AddVehicle(2, bus);

                vehiclePark.AddVehicle(3,
                    new Scooter(
                        new Engine(59m, 0.6m, AveilableEngineTypesEnum.ElectricEngine, 573445),
                        new Chassis(2, 45689384, 130),
                        new Transmission(AveilableTransmissionTypesEnum.AutomaticGearbox, 3, "Huawei"),
                        AveilableColourEnum.Blue));

                Engine temp = new Engine(320m, 4m, AveilableEngineTypesEnum.ElectricEngine, 954759);
                string tempString = temp.ToString();

                Vehicle vehicle = vehiclePark.GetAutoByParameter("lALA", tempString);

                vehiclePark.UpdateAuto(3,
                    new Truck(
                        new Engine(800m, 8m, AveilableEngineTypesEnum.DieselEngine, 5894582),
                        new Chassis(4, 985498, 1000),
                        new Transmission(AveilableTransmissionTypesEnum.MechanicalGearbox, 5, "huawei"),
                        250));

                vehiclePark.RemoveAuto(2);
            }
            catch(VehicleException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
