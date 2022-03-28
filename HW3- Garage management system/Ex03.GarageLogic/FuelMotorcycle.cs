using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuelMotorcycle : Motorcycle
    {
        internal FuelMotorcycle()
        {
            GetFuelOrPowerType = new FuelVehicle(5.5F, eFuel.Ocatn98);
        }

        public override string ToString()
        {
            return String.Format(@"type: Fuel Motorcycle", base.ToString());
        }
    }
}
