using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

// $G$ DSN-999 (-5) Why static? it's not object-oriented. You should have had an instance of this class created by the Main and 
// call a Run() method. This class should have members (such as GarageManager class) and not local variables within a method.

namespace Ex03.ConsoleUI
{
    internal class Garage
    {
        private static GarageManager m_GarageManager;
        

        internal static void Start()
        {

            Console.WriteLine("WELCOME TO OUR GARAGE\n");
            bool stay = true;
            m_GarageManager = new GarageManager();


            while (stay)
            {
                Console.WriteLine("Choose the number that indicates what you want to do in the garage:\n");
                Console.WriteLine("1.insert a new Vehicle. \n");
                Console.WriteLine("2.show List of vehicle By Status. \n");
                Console.WriteLine("3.set Status. \n");
                Console.WriteLine("4.fill Air for wheels To Max. \n");
                Console.WriteLine("5.fill Fuel. \n");
                Console.WriteLine("6.fill Power. \n");
                Console.WriteLine("7.show Vehicle Info.\n");
                Console.WriteLine("8.to exit.\n");

                string jobInput = Console.ReadLine();
                int job;
                while (!int.TryParse(jobInput, out job) && (job < 1 || job > 8))
                {
                    Console.WriteLine("not an option, write 1-8");
                }

                
                int.TryParse(jobInput, out job);
                

                eJobs jobType = (eJobs)job;
                Console.Clear();

                switch (jobType)
                {

                    case eJobs.insertNewVehicle:
                        InsertToGarage.insertToGarage(m_GarageManager);
                        break;

                    case eJobs.showList:
                        GarageList.garageList(m_GarageManager);
                        break;
                    case eJobs.setStatus:
                        SetStatus.setStatus(m_GarageManager);
                        break;
                    case eJobs.fillAirToMax:
                        FillWheelsToMax.fillWheelsToMax(m_GarageManager);
                        break;
                    case eJobs.fillFuel:
                        FillFuel.fillFuel(m_GarageManager);
                        break;
                    case eJobs.fillPower:
                        FillPower.fillPower(m_GarageManager);
                        break;
                    case eJobs.showVehicleInfo:
                        ShowInfo.showInfo(m_GarageManager);
                        break;

                    case eJobs.exit:
                        Console.WriteLine("Hope you engoy");
                        stay = false;
                        break;
                }
                Console.Clear();

            }

        }

    }

    public enum eJobs
    {
        insertNewVehicle = 1,
        showList = 2,
        setStatus = 3,
        fillAirToMax = 4,
        fillFuel = 5,
        fillPower = 6,
        showVehicleInfo = 7,
        exit = 8
    }
}

