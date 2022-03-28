using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : Motorcycle
    {
        internal ElectricMotorcycle()
        {
            GetFuelOrPowerType = new ElectricVehicle(1.6F);
        }

        public override string ToString()
        {
            return String.Format(@"type: Electric Motorcycle", base.ToString());
        }
    }
}
