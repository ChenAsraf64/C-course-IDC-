using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Customer
    {
        private string m_OwnerName;
        private string m_OwnerNummber;
        private eStatus m_Status;
        private Vehicle m_Vehicle;

        public Customer(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerNummber)
        {
            m_Vehicle = i_Vehicle;
            m_OwnerName = i_OwnerName;
            m_OwnerNummber = i_OwnerNummber;
        }

        public eStatus GetSetStatus
        {
            get { return m_Status; }
            set { m_Status = value; }
        }

        public Vehicle GetSetVehicle
        {
            get { return m_Vehicle; }
            set { m_Vehicle = value; }
        }


        public string GetSetOwnerName
        {
            get { return m_OwnerName; }
            set { m_OwnerName = value; }
        }

        public string GetSetOwnerNummber
        {
            get { return m_OwnerNummber; }
            set { m_OwnerNummber = value; }
        }

    }
    public enum eStatus
    {
        InRepair = 1,
        fix = 2,
        paidUp = 3
    }
}
