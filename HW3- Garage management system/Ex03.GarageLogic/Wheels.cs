using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Wheels
    {
        private string m_NameOfManufacture;
        private float m_CurrentAirPressur;
        private float m_MaxAirPressure;

        public Wheels(float i_MaxAirPressure)
        {
            m_NameOfManufacture = "";
            m_CurrentAirPressur = 0F;
            m_MaxAirPressure = i_MaxAirPressure;
        }

        public Wheels(string i_NameOfManufacture, float i_MaxAirPressure, float i_CurrentAirPressur)
        {
            m_NameOfManufacture = i_NameOfManufacture;
            m_CurrentAirPressur = i_CurrentAirPressur;
            m_MaxAirPressure = i_MaxAirPressure;
        }

        // $G$ NTT-005 (-5) You should use properties, not Get/Set methods.
        public void SetAirPressure(float i_AirPressureToAdd)
        {
            if (i_AirPressureToAdd + m_CurrentAirPressur > m_MaxAirPressure || i_AirPressureToAdd < 0)
            {
                throw new ValueOutOfRangeException(0, i_AirPressureToAdd);
            }
            else
            {
                m_CurrentAirPressur += m_MaxAirPressure;
            }
        }


        public string GetSetManufactureName
        {
            get { return m_NameOfManufacture; }
            set { m_NameOfManufacture = value; }
        }

        public float GetSetAirPressur
        {
            get { return m_CurrentAirPressur; }
            set { m_CurrentAirPressur = value; }
        }

        public float GetSetMaxAirPressure
        {
            get { return m_MaxAirPressure; }
            set { m_MaxAirPressure = value; }
        }
        public void AddAirPressureToMax()
        {
            m_CurrentAirPressur = GetSetMaxAirPressure;
        }
    }
}
