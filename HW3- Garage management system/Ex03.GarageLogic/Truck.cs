using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    // $G$ DSN-999 (-5) This class should have been internal.
    public class Truck : Vehicle
    {
        private bool m_HazardousMaterial = false;
        private float m_ChargerCapacity;
        private const int k_NumWheels = 16;
        private const float k_WheelMaxPressure = 26;
        private const float k_FuelCapacity = 110F;
        private const string k_fuelTypes = "Soler";

        public Truck()
        {
            for (int i = 0; i < 16; i++)
            {
                Wheels wheelToAdd = new Wheels(k_WheelMaxPressure);
                base.Wheels.Add(wheelToAdd);
            }
            
            base.GetSetFuel = eFuel.Soler;
            GetFuelOrPowerType = new FuelVehicle(110F, eFuel.Soler);
        }


        public bool HazardousMaterial
        {
            get { return m_HazardousMaterial; }
            set { m_HazardousMaterial = value;}
        }

        public float GetSetChargerCapacity
        {
            get { return m_ChargerCapacity; }
            set { m_ChargerCapacity = value; }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(@"Hazardous Material:{0} \n Charger Capacity:{1} \n nummber of wheels:{2}\n",
                m_HazardousMaterial, m_ChargerCapacity, k_NumWheels);
        }

    }
}
