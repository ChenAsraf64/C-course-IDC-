using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class GarageList
    {
        public static void garageList(GarageManager i_GarageManager)
        {
            try
            {
                Console.WriteLine("if you want to see all the list write 1, if you want for list by status write 2");
                string options = Console.ReadLine();

                while (!(options.Equals("1") || options.Equals("2")))
                {
                    Console.WriteLine("it not an aption, try again");
                    options = Console.ReadLine();
                }

                if (options.Equals("1"))
                {
                    List<string> garageList = i_GarageManager.ListOfGarage();
                    Console.WriteLine("The list:");
                    foreach (string inList in garageList)
                    {
                        Console.WriteLine(inList);
                    }
                }
                else
                {
                    Console.WriteLine("choose the nummber of the status:\n 1.InRepair \n 2.fix  \n 3.paidUp");
                    string status = Console.ReadLine();
                    int numStatus;

                    while (!int.TryParse(status, out numStatus) && (numStatus < 1 || numStatus > 3))
                    {
                        Console.WriteLine("it not an aption, try again");
                        status = Console.ReadLine();
                    }
                    int.TryParse(status, out numStatus);
                    eStatus statusToShow = (eStatus)numStatus;

                    List<string> listByStatus = i_GarageManager.ListOfGarageByStatus(statusToShow);

                    Console.WriteLine("The list:");
                    foreach (string inList in listByStatus)
                    {
                        Console.WriteLine(inList);
                    }
                }
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
