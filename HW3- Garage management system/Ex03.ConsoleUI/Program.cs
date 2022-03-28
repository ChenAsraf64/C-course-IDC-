using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic;

// $G$ RUL-005 (-10) Wrong zip folder structure, the zip file should contain a single folder. 
// $G$ RUL-999 (-5) Wrong solution name.

// $G$ SFN-003 (-5) The program does not cope as expected with incorrect input, should inform the user with the specific incorrect input. Air pressure can not be negative.
// $G$ SFN-004 (-5) The program does not print the current license list, with the option to filter by its status in the garage.
// $G$ SFN-009 (-5) The program does not print vehicle info.

namespace Ex03.ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            Garage.Start();
        }
    }
}
