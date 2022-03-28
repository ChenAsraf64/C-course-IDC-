using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    // $G$ DSN-999 (-3) This class should have been abstract.
    public class Vehicle
    {
        private string m_ModelName;
        private string m_NumberOfLicensing;
        private float m_PercentOfEnergy;
        // $G$ DSN-005 (0) This property should have been read-only.
        private List<Wheels> m_Wheels;
        //private string m_NameOwner;
        //private string m_PhoneNumbberOfOwner;
        private FuelOrPower m_Type;
        //private int m_NummberOfWheels;
        private eFuel m_TypeFuel;
        //private eStatus m_Status;


        // $G$ DSN-006 (-3) This method should have been protected.
        public Vehicle()
        {
            m_ModelName = "";
            m_NumberOfLicensing = "";
            m_Wheels = new List<Wheels>();
            m_Type = null;
        }

 

        public eFuel GetSetFuel
        {
            get { return m_TypeFuel; }
            set { m_TypeFuel = value; }
        }


        public Vehicle(string i_ModelName, string i_NumberOfLicensing, float i_PercentOfEnergy)
        {
            m_ModelName = i_ModelName;
            m_NumberOfLicensing = i_NumberOfLicensing;
            m_PercentOfEnergy = i_PercentOfEnergy;
        }

        
        public List<Wheels> Wheels
        {
            get { return m_Wheels; }
           // set { m_Wheels = value; }
        }


        public void SetMaxAirPressure()
        {
            foreach (Wheels wheels in m_Wheels)
            {
                wheels.AddAirPressureToMax();
            }
        }

        public FuelOrPower GetFuelOrPowerType
        {
            get { return m_Type; }
            set { m_Type = value; }
        }

        public string GetSetModelName
        {
            get { return m_ModelName; }
            set { m_ModelName = value; }
        }

        public string GetSetNumberOfDrivingLicence
        {
            get { return m_NumberOfLicensing; }
            set { m_NumberOfLicensing = value; }
        }

        public float GetSetEnergyPrecent
        {
            get { return m_PercentOfEnergy; }
            set { m_PercentOfEnergy = value; }
        }




        public override string ToString()
        {
            return String.Format(@"the Number of Licensing: {0} \n 
the Energy Percent: {0}  
the Type of Energy: {1} 
the Model Name: {2} 
Name Of Manufacture of wheels: {3} 
Current Air Pressur of wheels: {4} 
Max Air Pressure of wheels: {5} ",
           m_NumberOfLicensing, m_PercentOfEnergy, m_Type.ToString(), m_ModelName, m_Wheels[0].GetSetManufactureName,
           m_Wheels[0].GetSetAirPressur, m_Wheels[0].GetSetMaxAirPressure, Environment.NewLine);
    

        }


    }


}
