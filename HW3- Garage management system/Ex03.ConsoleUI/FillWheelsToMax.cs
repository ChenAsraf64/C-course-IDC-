using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class FillWheelsToMax
    {
        // $G$ CSS-011 (-3) Public methods should start with an Uppercase letter.
        public static void fillWheelsToMax(GarageManager i_GarageManager)
        {
            Console.WriteLine("write the Number Of Licensing that you want to fill");
            string NumLicensing = Console.ReadLine();
            try
            {
                while (!i_GarageManager.CheckIfExist(NumLicensing))
                {
                    Console.WriteLine("there is no vehicle with this Number Of Licensing, try again");
                    NumLicensing = Console.ReadLine();
                }

                i_GarageManager.FillWheelsToMax(NumLicensing);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
