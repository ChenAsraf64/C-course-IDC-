using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class SetStatus
    {
        public static void setStatus(GarageManager i_GarageManager)
        {
            Console.WriteLine("write the Number Of Licensing that you want to change");
            string NumLicensing = Console.ReadLine();

            while (!i_GarageManager.CheckIfExist(NumLicensing))
            {
                Console.WriteLine("there is no vehicle with this Number Of Licensing, try again");
                NumLicensing = Console.ReadLine();
            }

            Console.WriteLine("write the Number Of status:1.InRepair \n 2.fix \n 3.paidUp ");
            string status = Console.ReadLine();
            int NumStatus;

            while (!int.TryParse(status, out NumStatus) && (NumStatus < 1 || NumStatus > 3))
            {
                Console.WriteLine("not an option, try again");
                NumLicensing = Console.ReadLine();
            }

            int.TryParse(status, out NumStatus);
            eStatus statusToSet = (eStatus)NumStatus;

            i_GarageManager.SetStatus(NumLicensing, statusToSet);
        }
    }
}
