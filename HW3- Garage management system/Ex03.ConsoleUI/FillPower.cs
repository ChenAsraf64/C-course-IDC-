using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class FillPower
    {
        public static void fillPower(GarageManager i_GarageManager)
        {


            Console.WriteLine("please write the Number Of Licensing");
            string LicensingInput = Console.ReadLine();

            while (LicensingInput.Equals(null))
            {
                Console.WriteLine("try again, it not an nummber");
                LicensingInput = Console.ReadLine();
            }
            try
            {
                while (!i_GarageManager.CheckIfExist(LicensingInput))
                {
                    Console.WriteLine("there is no vehicle with this Number Of Licensing, try again");
                    LicensingInput = Console.ReadLine();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("write how much you want to fill");
            string HowMushInput = Console.ReadLine();
            float HowMush;

            while (!float.TryParse(HowMushInput, out HowMush))
            {
                Console.WriteLine("try again, it not an nummber");
                HowMushInput = Console.ReadLine();
            }

            float.TryParse(HowMushInput, out HowMush);

            try
            {
                i_GarageManager.FillPower(LicensingInput, HowMush);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
