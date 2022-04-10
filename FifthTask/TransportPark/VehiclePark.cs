using System.Linq;
using System.Collections.Generic;
using CollectionsAndExceptions.Exceptions;

namespace CollectionsAndExceptions.Transport
{
    public class VehiclePark
    {
        private Dictionary<int, Vehicle> vehicles;

        public VehiclePark() 
        {
            vehicles = new Dictionary<int, Vehicle>();
        }

        public VehiclePark(int newId, Vehicle newVehicle) : this() 
        {
            vehicles.Add(newId , newVehicle);            
        }

        public void AddVehicle(int newId, Vehicle newVehicle)
        {
            if (vehicles.Where(p => p.Key == newId).ToList().Count == 0)
            {
                vehicles.Add(newId, newVehicle);
            }
            else
            {
                throw new AddException("Vehicle with that id already exists");
            }
        }

        /// <summary>
        /// Gets vehicle by valid parameter
        /// </summary>
        /// <exception cref="GetAutoByParameterException"></exception>
        public Vehicle GetAutoByParameter(string parameter, string value)
        {
            foreach (var vehicle in vehicles)   
            {
                var vehicleType = vehicle.Value.GetType();
                var vehiclePropertyInfos = vehicleType.GetProperties();
                foreach (var propertyInfo in vehiclePropertyInfos)
                {
                    if(propertyInfo.Name == parameter && propertyInfo.GetValue(vehicle.Value).ToString() == value)
                    {
                        return vehicle.Value;
                    }
                }
            }

            throw new GetAutoByParameterException("Invalid Parameter");
        }

        public void UpdateAuto(int id, Vehicle newVehicle)
        {
            if (vehicles.Where(p => p.Key == id).ToList().Count != 0)
            {
                vehicles[id] = newVehicle;
            }
            else
            {
                throw new UpdateAutoException("id doesnt exist");
            }
        }

        public void RemoveAuto(int id)
        {
            if (vehicles.ContainsKey(id))
            {
                vehicles.Remove(id);
            }
            else
            {
                throw new RemoveAutoException("id doesnt exist");
            }
        }
    }
}
