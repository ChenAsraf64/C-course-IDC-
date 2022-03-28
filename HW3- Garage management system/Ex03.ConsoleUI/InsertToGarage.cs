using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

// $G$ DSN-001 (-10) The UI must not know specific types and their properties concretely! It means that when adding a new type you'll have to change the code here too!


namespace Ex03.ConsoleUI
{
    internal class InsertToGarage
    {
        // $G$ DSN-007 (-5) This method is too long, should be divided into several methods.
        internal static void insertToGarage(GarageManager i_GarageManager)
        {

            string NumberOfLicensing;
            string OwnerName;
            string OwnerNummber;

            Console.WriteLine("please write your number of licensing");
            NumberOfLicensing = Console.ReadLine();

            while (i_GarageManager.CheckIfExist(NumberOfLicensing))
            {
                Console.WriteLine("try again, this nummber exist in the garage");
                NumberOfLicensing = Console.ReadLine();
            }

            Console.WriteLine("please write your name");
            OwnerName = Console.ReadLine();
            Console.WriteLine("please write your phone nummber");
            OwnerNummber = Console.ReadLine();


            Console.WriteLine("please write the nummber  of the type of your vehicle:");
            Console.WriteLine("\n 1.FuelMotorcycle \n 2.ElectricMotorcycle \n 3.FuelCar \n 4.ElectricCar \n 5.Truck  \n 6.other");
            string typeVehicleInput = Console.ReadLine();
            int numTypeInt;
            while (!int.TryParse(typeVehicleInput, out numTypeInt) || numTypeInt < 1 || numTypeInt > 7)
            {
                Console.WriteLine("try again, write nummber from 1-6");
                typeVehicleInput = Console.ReadLine();
            }
            int.TryParse(typeVehicleInput, out numTypeInt);

            Vehicle vehicleUser = new Vehicle();
            if (numTypeInt != 6)
            {
                CreateNewVehicle.e_TypyOfVehicle typeVehicle = (CreateNewVehicle.e_TypyOfVehicle)numTypeInt;

                vehicleUser = CreateNewVehicle.vehicleByType(typeVehicle);
            }
            else
            {
                Console.WriteLine("please write the Name Of your wheels that you have:");
                string numInput = Console.ReadLine();
                int input;

                while (!int.TryParse(numInput, out input))
                {
                    Console.WriteLine("it not an option, try again.");
                    numInput = Console.ReadLine();
                }
                int.TryParse(numInput, out input);
                

                Console.WriteLine("please write the max air ptessuer of wheels:");
                string numInput2 = Console.ReadLine();
                float input2;

                while (!float.TryParse(numInput2, out input2))
                {
                    Console.WriteLine("it not an option, try again.");
                    numInput2 = Console.ReadLine();
                }
                float.TryParse(numInput2, out input2);

                for (int i = 0; i < input; i++ )
                {
                    vehicleUser.Wheels.Add(new  Wheels(input2));
                }

            }
           

            Console.WriteLine("please write the Name Of Manufacture of you wheels:");
            vehicleUser.Wheels[0].GetSetManufactureName = Console.ReadLine(); 

            Console.WriteLine("please write the nummber Current Air Pressur of you wheels:");
            string CurrentAirPressurInput = Console.ReadLine();
            float CurrentAirPressur;

            while (!float.TryParse(CurrentAirPressurInput, out CurrentAirPressur))
            {
                Console.WriteLine("it not an option, try again.");
                CurrentAirPressurInput = Console.ReadLine();
            }

            float.TryParse(CurrentAirPressurInput, out CurrentAirPressur);


            Console.WriteLine("please write the nummber of Percent Of Energy of the vehicle:");
            string PercentOfEnergyInput = Console.ReadLine();
            float PercentOfEnergy;

            while (!float.TryParse(PercentOfEnergyInput, out PercentOfEnergy))
            {
                Console.WriteLine("it not an option, try again.");
                PercentOfEnergyInput = Console.ReadLine();
            }

            float.TryParse(PercentOfEnergyInput, out PercentOfEnergy);



            vehicleUser.GetSetEnergyPrecent = PercentOfEnergy;
            vehicleUser.GetSetNumberOfDrivingLicence = NumberOfLicensing;


            if (vehicleUser is Car)
            {
                Console.WriteLine("please write the nummber of the color:");
                Console.WriteLine("\n 1.Yellow  \n 2.White  \n 3.Black  \n 4.Blue");
                string colorInput = Console.ReadLine();
                int colorInt;
                while (!(int.TryParse(colorInput, out colorInt)) && (colorInt < 1 || colorInt > 4))
                {
                    Console.WriteLine("it not an option, try again.");
                    colorInput = Console.ReadLine();
                }
                int.TryParse(colorInput, out colorInt);

                (vehicleUser as Car).SetGetColor = (eCarColors)colorInt;





                Console.WriteLine("please write the nummber of the doors in your car:");
                Console.WriteLine("\n 2  \n 3  \n 4  \n 5");
                string NumDoors = Console.ReadLine();

                while (!(NumDoors.Equals("2") || NumDoors.Equals("3") || NumDoors.Equals("4") || NumDoors.Equals("4")))
                {
                    Console.WriteLine("it not an option, try again.");
                    NumDoors = Console.ReadLine();
                }
                int numDoors;
                int.TryParse(NumDoors, out numDoors);
                (vehicleUser as Car).SetGetDoors = (eEmountOfDoors)numDoors;
            }

            if (vehicleUser is Motorcycle)
            {

                int numLicencesMotorcycle;
                Console.WriteLine("please write your nummber of your Licences type:");
                Console.WriteLine("\n 1.A  \n 2.A1  \n 3.A2  \n 4.B");
                string TypeOfLicences = Console.ReadLine();

                while (!int.TryParse(TypeOfLicences, out numLicencesMotorcycle) || (numLicencesMotorcycle < 1 || numLicencesMotorcycle > 4))
                {
                    Console.WriteLine("it not an option, try again.");
                    TypeOfLicences = Console.ReadLine();
                }
                int.TryParse(TypeOfLicences, out numLicencesMotorcycle);

                (vehicleUser as Motorcycle).SetGetLicencesType = (eLicenceType)numLicencesMotorcycle;

                Console.WriteLine("please write The Engine Capicity of your Motorcycle:");
                string Capicity = Console.ReadLine();
                int EngineCapicity;

                while (!int.TryParse(Capicity, out EngineCapicity))
                {
                    Console.WriteLine("it not an option, try again.");
                    Capicity = Console.ReadLine();
                }
                int.TryParse(Capicity, out EngineCapicity);

                (vehicleUser as Motorcycle).SetGetEngineCapicity = EngineCapicity;
            }

            if (vehicleUser is Truck)
            {

                Console.WriteLine("please write The Charger Capacity For your Truck:");
                string Capicity = Console.ReadLine();
                float capicity;

                while (!float.TryParse(Capicity, out capicity))
                {
                    Console.WriteLine("it not an option, try again.");
                    Capicity = Console.ReadLine();
                }
                float.TryParse(Capicity, out capicity);
                (vehicleUser as Truck).GetSetChargerCapacity = capicity;

                Console.WriteLine("please write yes or no, do you have Hazardous Material in your Truck?");
                string check = Console.ReadLine();
                bool CheckHazardousMaterial = false;
                while (!(check.Equals("yes") || check.Equals("no")))
                {
                    Console.WriteLine("it not an option, try again.");
                    check = Console.ReadLine();
                }

                if (check.Equals("yes"))
                {
                    CheckHazardousMaterial = true;
                }
                (vehicleUser as Truck).HazardousMaterial = CheckHazardousMaterial;
            }


            i_GarageManager.AddNewCustomer(vehicleUser, OwnerName, OwnerNummber);
        }


    }
}
