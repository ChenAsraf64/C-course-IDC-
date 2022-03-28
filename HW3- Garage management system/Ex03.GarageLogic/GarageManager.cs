using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        // $G$ DSN-005 (-2) This property should have been read-only.
        private Dictionary<string, Customer> m_GarageManager;

        public GarageManager()
        {
            m_GarageManager = new Dictionary<string,Customer>();
        }

        public Dictionary<string, Customer> GetGarageManager
        {
            get { return m_GarageManager; }
            set { m_GarageManager = value; }

        }

        public bool CheckIfExist(string i_NumberOfLicensing)
        {
            bool check = false;

            if (i_NumberOfLicensing.Equals(null))
            {
                throw new ArgumentException("not correct input");
            }
            else if (m_GarageManager.ContainsKey(i_NumberOfLicensing))
            {
                check = true;
            }

            return check;
        }


        public void AddNewCustomer(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerNummber)
        {
            if (CheckIfExist(i_Vehicle.GetSetNumberOfDrivingLicence))
            {
                SetStatus(i_Vehicle.GetSetNumberOfDrivingLicence, eStatus.InRepair);
                throw new ArgumentException("already in the garage!");
            }
            else
            {
                Customer customer = new Customer(i_Vehicle, i_OwnerName, i_OwnerNummber);
                m_GarageManager.Add(i_Vehicle.GetSetNumberOfDrivingLicence, customer);
                SetStatus(customer.GetSetVehicle.GetSetNumberOfDrivingLicence, eStatus.InRepair);
            }

            
        }


        public void SetStatus(string i_NumberOfLicensing, eStatus i_status)
        {
            if (!CheckIfExist(i_NumberOfLicensing))
            {
                throw new ArgumentException("not exsit");
            }
            else
            {
                Customer customer = m_GarageManager[i_NumberOfLicensing];
                Vehicle vehicle = customer.GetSetVehicle;
                customer.GetSetStatus = i_status;
            }
        }


        public List<string> ListOfGarage()
        {
            List<string> ListOfGarage = new List<string>();


            foreach (Customer customer in m_GarageManager.Values)
            {
                ListOfGarage.Add(customer.GetSetVehicle.GetSetNumberOfDrivingLicence);
            }

            return ListOfGarage;
        }



        public List<string> ListOfGarageByStatus(eStatus i_status)
        {
            List<string> ListOfGarageByNummberOfStatus = new List<string>();

            foreach (Customer customer in m_GarageManager.Values)
            {
                if (customer.GetSetStatus.Equals(i_status))
                {
                    ListOfGarageByNummberOfStatus.Add(customer.GetSetVehicle.GetSetNumberOfDrivingLicence);
                }

            }
            return ListOfGarageByNummberOfStatus;
        }

        public void FillFuel(string i_NumberOfLicensing, eFuel i_Type, float i_HowMush)
        {
            if (!CheckIfExist(i_NumberOfLicensing))
            {
                throw new ArgumentException("not exsit");
            }
            else if (!m_GarageManager[i_NumberOfLicensing].GetSetVehicle.GetFuelOrPowerType.Equals((eFuelOrPower)2))
            {
                throw new ArgumentException("not correct this is electric vehicle");
            }
            else if (!m_GarageManager[i_NumberOfLicensing].GetSetVehicle.GetSetFuel.Equals(i_Type))
            {
                throw new ArgumentException("not correct, this is not the fule type of this vehicle");
            }
            else
            {
                Customer customer = m_GarageManager[i_NumberOfLicensing];
                Vehicle vehicle = customer.GetSetVehicle;
                FuelOrPower fuelVehicle = vehicle.GetFuelOrPowerType;
            }
        }

        public void FillPower(string i_NumberOfLicensing, float i_HowMush)
        {
            if (!CheckIfExist(i_NumberOfLicensing))
            {
                throw new ArgumentException("not exsit");
            }
            else if (!m_GarageManager[i_NumberOfLicensing].GetSetVehicle.GetFuelOrPowerType.Equals((eFuelOrPower)1))
            {
                throw new ArgumentException("not correct this is fuel vehicle");
            }
            else
            {
                Customer customer = m_GarageManager[i_NumberOfLicensing];
                Vehicle vehicle = customer.GetSetVehicle;
                FuelOrPower fuelVehicle = vehicle.GetFuelOrPowerType;
                (fuelVehicle as ElectricVehicle).FillPower(i_HowMush);
            }
        }

        public void FillWheelsToMax(string i_NumberOfLicensing)
        {
            if (!CheckIfExist(i_NumberOfLicensing))
            {
                throw new ArgumentException("not exsit");
            }
            else
            {
                Customer customer = m_GarageManager[i_NumberOfLicensing];
                Vehicle vehicle = customer.GetSetVehicle;
                vehicle.SetMaxAirPressure();

            }
        }

        public StringBuilder ShowInfo(string i_NumberOfLicensing)
        {
            if (!CheckIfExist(i_NumberOfLicensing))
            {
                throw new ArgumentException("not exsit");
            }
            else
            {
                StringBuilder showInfo = new StringBuilder("");
                
                showInfo.Append(m_GarageManager[i_NumberOfLicensing].GetSetVehicle.ToString());
                return showInfo;
            }
        }

        public bool IsEmpty()
        {
            bool isEmpty = false;
            if (m_GarageManager.Count == 0)
            {
                isEmpty = true;
            }

            return isEmpty;
        }


    }
}
