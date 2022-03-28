using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricCar : Car
    {
        internal ElectricCar()
        {
            GetFuelOrPowerType = new ElectricVehicle(2.8F); 
        }

        public override string ToString()
        {
            return String.Format(@"type: Electric Car", base.ToString());
        }
    }
}
