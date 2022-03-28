using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// $G$ DSN-999 (-5) Fuel car and electric car the same and differ by the engine type.

namespace Ex03.GarageLogic
{
    public class FuelCar : Car
    {
        internal FuelCar()
        {
            GetFuelOrPowerType = new FuelVehicle(50F, eFuel.Ocatan95);
        }

        public override string ToString()
        {
            return String.Format(@"type: Fuel car", base.ToString());
        }
    }
}
