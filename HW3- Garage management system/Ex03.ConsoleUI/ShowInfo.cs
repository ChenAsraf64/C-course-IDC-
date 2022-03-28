using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class ShowInfo
    {
        internal static void showInfo(GarageManager i_GarageManager)
        {
            try
            {
                Console.WriteLine("write the Number Of Licensing that you want to see");
                string NumLicensing = Console.ReadLine();
                StringBuilder info = i_GarageManager.ShowInfo(NumLicensing);
                Console.WriteLine(info);
            }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
           

        }
    }
}
