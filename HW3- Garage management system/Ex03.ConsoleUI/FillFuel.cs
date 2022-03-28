using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class FillFuel
    {

        public static void fillFuel(GarageManager i_GarageManager)
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
            // $G$ CSS-001 (-3) Bad variable name (should be in the form of camelCase).
            string HowMushInput = Console.ReadLine();
            float HowMush;

            while (!float.TryParse(HowMushInput, out HowMush))
            {
                Console.WriteLine("try again, it not an nummber");
                HowMushInput = Console.ReadLine();
            }

            float.TryParse(HowMushInput, out HowMush);

            Console.WriteLine("write the nummber type of fuel to fill:\n 1.Soler\n 2.Ocatan95 \n 3.Octan96 \n 4.Ocatn98 \n");
            string typeInput = Console.ReadLine();
            int type;

            while (!int.TryParse(typeInput, out type) && (type < 1 || type > 4) )
            {
                Console.WriteLine("try again, it not an option");
                typeInput = Console.ReadLine();
            }
            int.TryParse(typeInput, out type);
            eFuel typeToFill = (eFuel)type;

            try
            {
                i_GarageManager.FillFuel(LicensingInput, typeToFill, HowMush);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
