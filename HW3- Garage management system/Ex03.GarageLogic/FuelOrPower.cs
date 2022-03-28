using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class FuelOrPower
    {
        private float m_CurrentBatteryOrPowerThatLeft;
        private float m_MaxBatteryOrPowerThatLeft;
        // $G$ DSN-007 (-2) Not all engines support this type of energy source. This property does not belong in this class.
        private eFuelOrPower m_Type;

        internal eFuelOrPower GetFuelOrPowerType
        {
            get { return m_Type; }
        }

        internal FuelOrPower(float i_MaxBatteryOrPowerThatLeft, eFuelOrPower i_TypeVehicle)
        {
            m_MaxBatteryOrPowerThatLeft = i_MaxBatteryOrPowerThatLeft;
            this.m_Type = i_TypeVehicle;
        }

        internal float GetSetMaxCapacity
        {
            get { return m_MaxBatteryOrPowerThatLeft; }
            set { m_MaxBatteryOrPowerThatLeft = value; }
        }

        internal float GetSetCureentCapacity
        {
            get { return m_CurrentBatteryOrPowerThatLeft; }
            set { m_CurrentBatteryOrPowerThatLeft = value; }

        }



        internal void SetFullBatteryOrFuel()
        {
            m_CurrentBatteryOrPowerThatLeft = m_MaxBatteryOrPowerThatLeft;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(@"type vehicle: {0} \n current capacity: {1} \n max capacity: {2}",
                                           m_Type, m_CurrentBatteryOrPowerThatLeft, m_MaxBatteryOrPowerThatLeft);
        }


        
    }

    public enum eFuelOrPower
    {
        FuelVehicle = 1,
        ElectricVehicle = 2
    }

   
}
