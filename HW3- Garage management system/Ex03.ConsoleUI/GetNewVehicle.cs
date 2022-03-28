using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class GetNewVehicle
    {
        private string m_TypeVehicle;
        private string m_ElectricOrFuel;
        private string m_NameOfManufactureOfWheels;
        private string m_TypeOfVehicleFuel;
        private float m_MaxFuel;
        private float m_MaxBatteryCapacity;
        private string m_TypeOfLicence;
        private int m_EngineCapicity;
        private string m_SpecificCarColor;
        private string m_NumbersOfDoors;
        private bool m_HazardousMaterial;
        private float m_ChargerCapacity;
        
        private string m_VehicelModel;
        private string m_TypeOfEnergy;
        private float m_EnergyPrecent;


        private void GetVehicle()
        {
            m_VehicelModel = getNotEmptyStringInput("Write Model Name Of Vehicle");
            string EnergyPrecent = getNotEmptyStringInput("write the Energy Precent");
            while (float.TryParse(EnergyPrecent, out m_EnergyPrecent))
            {
                Console.WriteLine("please try again");
                EnergyPrecent = getNotEmptyStringInput("write the Energy Precent");
            }

            m_TypeOfEnergy = getNotEmptyStringInput("Write Fuel Type ");
            while (!(m_TypeOfEnergy.Equals("Electric") || m_TypeOfEnergy.Equals("Fuel")))
            {
                Console.WriteLine("please try again");
                m_TypeOfEnergy = getNotEmptyStringInput("Write Type Of Vehicle From Options: Car, Motorcycle, Truck");
            }

            Vehicle vehicle;
            if (m_TypeOfEnergy.Equals("Car"))
            {
                vehicle = GetCar();

            }
            if (m_TypeOfEnergy.Equals("Motorcycle"))
            {
                vehicle = GetMotorcycle();
            }
            if (m_TypeOfEnergy.Equals("Fuel"))
            {
                vehicle = GetTruck();
            }
        }

        public Vehicle GetCar()
        {
            Vehicle car;
            m_ElectricOrFuel = getNotEmptyStringInput("Please choose one of the options: Fuel, Electric");
            while (! (m_ElectricOrFuel.Equals("Fuel") || m_ElectricOrFuel.Equals("Electric")) )
            {
                Console.WriteLine("it not an opption, please choose again");
                m_ElectricOrFuel = getNotEmptyStringInput("Please choose one of the options: Fuel, Electric");
            }
            if (m_ElectricOrFuel.Equals("Fuel"))
            {
               car = CreateNewVehicle.CreateVehicle(CreateNewVehicle.e_TypyOfVehicle.FuelCar);
               m_ElectricOrFuel = "Fuel";
            }
            else // (m_ElectricOrFuel.Equals("Electric"))
            {
                car = CreateNewVehicle.CreateVehicle(CreateNewVehicle.e_TypyOfVehicle.ElectricCar);
                m_ElectricOrFuel = "Electric";
            }

            return car;

        }

        public Vehicle GetMotorcycle()
        {
            Vehicle motorcycle;
            m_ElectricOrFuel = getNotEmptyStringInput("Please choose one of the options: Fuel, Electric");
            while (!(m_ElectricOrFuel.Equals("Fuel") || m_ElectricOrFuel.Equals("Electric")))
            {
                Console.WriteLine("it not an opption, please choose again");
                m_ElectricOrFuel = getNotEmptyStringInput("Please choose one of the options: Fuel, Electric");
            }
            if (m_ElectricOrFuel.Equals("Fuel"))
            {
                motorcycle = CreateNewVehicle.CreateVehicle(CreateNewVehicle.e_TypyOfVehicle.FuelMotorcycle);
                m_ElectricOrFuel = "Fuel";
            }
            else // (m_ElectricOrFuel.Equals("Electric"))
            {
                motorcycle = CreateNewVehicle.CreateVehicle(CreateNewVehicle.e_TypyOfVehicle.ElectricMotorcycle);
                m_ElectricOrFuel = "Electric";
            }

            return motorcycle;

        }

        public Vehicle GetTruck()
        {
            Vehicle truck;
            truck = CreateNewVehicle.CreateVehicle(CreateNewVehicle.e_TypyOfVehicle.Truck);
            m_ElectricOrFuel = "Fuel";


            return truck;
        }



        private void GetWheelsMoreInfo()
        {
            string NameOfManufactureOfWheels = getNotEmptyStringInput("Write Name Of Manufacture Of Wheels");
            m_NameOfManufactureOfWheels = NameOfManufactureOfWheels;
        }


/*        private void GetElectricVehicle()
        {
            Vehicle electricVehicle;
            Console.WriteLine("Please choose one of the options: Car, Motorcycle");
            string VehicleType = Console.ReadLine();
            while (!(VehicleType.Equals("Car") || VehicleType.Equals("Motorcycle")))
            {
                Console.WriteLine("please try again");
                VehicleType = Console.ReadLine();
            }
            if (VehicleType.Equals("Car"))
            {
               electricVehicle = CreateNewVehicle.CreateVehicle(CreateNewVehicle.e_TypyOfVehicle.ElectricCar);
            }
            else // (VehicleType.Equals("Motorcycle"))
            {
                electricVehicle = CreateNewVehicle.CreateVehicle(CreateNewVehicle.e_TypyOfVehicle.ElectricMotorcycle);
            }

            return electricVehicle;
        }

        private void GetWheelsMoreInfo()
        {
            string NameOfManufactureOfWheels = getNotEmptyStringInput("Write Name Of Manufacture Of Wheels");
            m_NameOfManufactureOfWheels = NameOfManufactureOfWheels;
        }


        private void GetElectricVehicle()
        {
            Console.WriteLine("Please choose one of the options: Car, Motorcycle");
            string VehicleType = Console.ReadLine();
            while (!(VehicleType.Equals("Car") || VehicleType.Equals("Motorcycle")))
            {
                Console.WriteLine("please try again");
                VehicleType = Console.ReadLine();
            }
            if (VehicleType.Equals("Car"))
            {
                m_TypeVehicle = "ElectricCar";
                m_NumberOfWheels = 4;
                m_MaxAirPressure = 30;
                m_MaxBatteryCapacity = 2.8F;
                CreateVehicle.CreateVehicle(5);
            }
            else // (VehicleType.Equals("Motorcycle"))
            {
                m_TypeVehicle = "ElectricMotorcycle";
                m_NumberOfWheels = 2;
                m_MaxAirPressure = 28;
                m_MaxBatteryCapacity = 1.6F;
                CreateVehicle.CreateVehicle(4);
            }


        }*/

        private void MoreInformationForCars()
        {
            string ColorOfTheCar = getNotEmptyStringInput("Write Color Of The Car");

            while (!(ColorOfTheCar.Equals("Yellow") || ColorOfTheCar.Equals("White") || ColorOfTheCar.Equals("Black") || ColorOfTheCar.Equals("Blue")))
            {
                Console.WriteLine("This is not an option");
                ColorOfTheCar = getNotEmptyStringInput("Write Color Of The Car(Yellow or White or Black or Blue)");
            }

            string NumDoorsOfTheCar = getNotEmptyStringInput("Write The Nummber Doors Of The Car");
            int IntNumDoorsOfTheCar;

            while (!int.TryParse(NumDoorsOfTheCar, out IntNumDoorsOfTheCar))
            {
                while (IntNumDoorsOfTheCar > 6 || IntNumDoorsOfTheCar < 1)
                {
                    Console.WriteLine("This is not an option");
                    ColorOfTheCar = getNotEmptyStringInput("Write Color Of The Car(Yellow or White or Black or Blue)");
                }
            }

            int.TryParse(NumDoorsOfTheCar, out IntNumDoorsOfTheCar);

            m_SpecificCarColor = ColorOfTheCar;

        }

        private void MoreInformationForMotorcycle()
        {
            string TypeOfLicence = getNotEmptyStringInput("Write Type Of Licence");

            while (!(TypeOfLicence.Equals("A") || TypeOfLicence.Equals("A1") || TypeOfLicence.Equals("A2") || TypeOfLicence.Equals("B")))
            {
                Console.WriteLine("This is not an option");
                TypeOfLicence = getNotEmptyStringInput("Write Type Of Licence or A or A1 or A2 or B"); ;
            }

            string EngineCapicity = getNotEmptyStringInput("Write The Nummber Of Engine Capicity");
            int IntEngineCapicity;

            while (!(int.TryParse(EngineCapicity, out IntEngineCapicity)))
            {
                Console.WriteLine("This is not an option");
                EngineCapicity = getNotEmptyStringInput("Write The Nummber Of Engine Capicity");
            }

            int.TryParse(EngineCapicity, out IntEngineCapicity);

            m_TypeOfLicence = TypeOfLicence;
            m_EngineCapicity = IntEngineCapicity;

        }

        private void MoreInformationForTruck()
        {
            string ContainsDangerousThings = getNotEmptyStringInput("Write yse or no: Contains Dangerous Things?");

            while (!(ContainsDangerousThings.Equals("yes") || ContainsDangerousThings.Equals("no")))
            {
                Console.WriteLine("This is not an option");
                ContainsDangerousThings = getNotEmptyStringInput("Write yse or no: Contains Dangerous Things?");
            }

            string ChargerCapacity = getNotEmptyStringInput("Write The Nummber Of Charger Capacity");
            int IntChargerCapacity;

            while (!(int.TryParse(ChargerCapacity, out IntChargerCapacity)))
            {
                Console.WriteLine("This is not an option");
                ChargerCapacity = getNotEmptyStringInput("Write The Nummber Of Charger Capacity");
            }

            int.TryParse(ChargerCapacity, out IntChargerCapacity);

            m_ChargerCapacity = IntChargerCapacity;
            if (ContainsDangerousThings.Equals("yes"))
            {
                m_HazardousMaterial = true;
            }
            else
            {
                m_HazardousMaterial = false;
            }

        }

        private string getNotEmptyStringInput(string i_StringName)
        {

            Console.WriteLine(String.Format("Please enter the {0} (not empty)", i_StringName));
            string stringInput = Console.ReadLine();

            while (String.IsNullOrEmpty(stringInput))
            {
                Console.WriteLine(String.Format("{0} can't be empty, Please try again:", i_StringName));
                stringInput = Console.ReadLine();
            }

            return stringInput;
        }


        public enum e_TypyOfVehicle
        {
            FuelMotorcycle = 1,
            FuelCar = 2,
            Truck = 3,
            ElectricMotorcycle = 4,
            ElectricCar = 5
        }
    }
}
