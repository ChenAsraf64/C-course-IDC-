using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuelVehicle : FuelOrPower
    {
        public eFuel m_TypeFuel;

        internal FuelVehicle(float i_MaxPower, eFuel i_TypeFuel)
            : base(i_MaxPower, eFuelOrPower.FuelVehicle)
        {
            m_TypeFuel = i_TypeFuel;
        }

        internal eFuel GetSetTypeFuel
        {
            get { return m_TypeFuel; }
            set { m_TypeFuel = value; }
        }

        internal void FillFuel(float i_HowMush, eFuel i_Type)
        {
            if (!i_Type.Equals(m_TypeFuel))
            {
                throw new ArgumentException("the type of fuel not fit to this vehicle");
            }
            else if (i_HowMush + base.GetSetCureentCapacity > base.GetSetCureentCapacity || i_HowMush < 0)
            {
                throw new ValueOutOfRangeException(0, base.GetSetMaxCapacity);
            }
            else if (i_HowMush > base.GetSetMaxCapacity)
            {
                throw new ValueOutOfRangeException(0, base.GetSetMaxCapacity);
            }
            else
            {
                if (i_Type.Equals(m_TypeFuel))
                {
                    base.GetSetCureentCapacity += i_HowMush;
                }
            }
        }


        public override string ToString()
        {
            return base.ToString() + String.Format("Type Fuel is:" , m_TypeFuel );
        }


    }

    public enum eFuel
    {
        Soler = 1,
        Ocatan95 = 2,
        Octan96 = 3,
        Ocatn98 = 4
    } 
}
