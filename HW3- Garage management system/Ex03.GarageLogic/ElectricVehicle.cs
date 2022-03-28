using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricVehicle : FuelOrPower
    {
        internal ElectricVehicle(float i_MaxPower)
            : base(i_MaxPower, eFuelOrPower.ElectricVehicle)
        {
        }

        internal void FillPower(float i_HowMuch)
        {
            if (i_HowMuch > base.GetSetMaxCapacity)
            {
                throw new ValueOutOfRangeException(0, base.GetSetMaxCapacity);
            }
            else if (i_HowMuch + base.GetSetCureentCapacity > base.GetSetMaxCapacity || i_HowMuch < 0)
            {
                throw new ValueOutOfRangeException(0, base.GetSetMaxCapacity);
            }
            else
            {
                base.GetSetCureentCapacity += i_HowMuch;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
