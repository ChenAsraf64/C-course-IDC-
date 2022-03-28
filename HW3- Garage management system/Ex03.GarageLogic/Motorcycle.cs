using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        private int m_EngineCapicity;
        private eLicenceType m_LicencesType;
        private const int k_NumWheels = 2;
        private const float k_WheelMaxPressure = 28;

        public Motorcycle()
        {
            for (int i = 0; i < 2; i++)
            {
                Wheels wheelToAdd = new Wheels(k_WheelMaxPressure);
                base.Wheels.Add(wheelToAdd);
            }
        }


        public eLicenceType SetGetLicencesType
        {
            get { return m_LicencesType; }
            set { m_LicencesType = value; }
        }

        public int SetGetEngineCapicity
        {
            get { return m_EngineCapicity; }
            set { m_EngineCapicity = value; }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(@"Licences Type:{0} \n Engine Capicity:{1} \n nummber of wheels: {2} \n",
                m_LicencesType, m_EngineCapicity, k_NumWheels);
        }

    }

    public enum eLicenceType
    {
        A = 1,
        A1 = 2,
        A2 = 3,
        B = 4
    }
}
