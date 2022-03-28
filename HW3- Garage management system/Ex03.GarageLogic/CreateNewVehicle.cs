using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class CreateNewVehicle
    {
        public static Vehicle vehicleByType(e_TypyOfVehicle i_TypyOfVehicle)
        {
            e_TypyOfVehicle vehicleType = (e_TypyOfVehicle)i_TypyOfVehicle;
            Vehicle vehicle;

            switch (vehicleType)
            {
                case e_TypyOfVehicle.FuelMotorcycle:
                    vehicle = new FuelMotorcycle();
                    break;
                case e_TypyOfVehicle.ElectricMotorcycle:
                    vehicle = new ElectricMotorcycle();
                    break;
                case e_TypyOfVehicle.FuelCar:
                    vehicle = new FuelCar();
                    break;
                case e_TypyOfVehicle.ElectricCar:
                    vehicle = new ElectricCar();
                    break;
                case e_TypyOfVehicle.Truck:
                    vehicle = new Truck();
                    break;
                default:
                    throw new ArgumentException("Not one of the type");
            }

            return vehicle;
        }

        // $G$ CSS-019 (-3) Bad enumeration name (should be in the form of ePascalCased).
        public enum e_TypyOfVehicle
        {
            FuelMotorcycle = 1,
            ElectricMotorcycle = 2,
            FuelCar = 3,
            ElectricCar = 4,
            Truck = 5
        }
    }
}



