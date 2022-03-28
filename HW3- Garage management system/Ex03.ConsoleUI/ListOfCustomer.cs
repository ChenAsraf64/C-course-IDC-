using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.ConsoleUI
{
    public class ListOfCustomer
    {
        List<Customer> m_ListOfCustomerOfTheGarage = new List<Customer>();

        public void AddCustomer(Customer i_Customer)
        {
            foreach (Customer customer in m_ListOfCustomerOfTheGarage)
            {
                while (customer.GetSetNumberOfLicensing.Equals(i_Customer.GetSetNumberOfLicensing))
                {
                    Console.WriteLine("this Number Of Licensing already in the garage, we set it to status InRepair");
                    customer.GetSetStatus = Customer.eStatus.InRepair;
                    break;
                }
            }

            m_ListOfCustomerOfTheGarage.Add(i_Customer);
            i_Customer.GetSetStatus = Customer.eStatus.InRepair;
        }

        public bool CheckIfExists(string i_NumberOfLicensing)
        {
            bool exsits = false;
            foreach (Customer customer in m_ListOfCustomerOfTheGarage)
            {
                while (customer.GetSetNumberOfLicensing.Equals(i_NumberOfLicensing))
                {
                    exsits = true;
                    break;
                }
            }
            return exsits;
        }


        public List<Object> ShowByStatus(Object.eStatus i_Status)
        {
            List<Object> ListByStatus = new List<Object>();
            foreach (Object customer in m_ListOfCustomerOfTheGarage)
            {
                if (customer.GetSetStatus == i_Status)
                {
                    ListByStatus.Add(customer);
                }
            }

            return ListByStatus;
        }

        private void ChangeStatus(string i_NumberOfLicensing, string i_Status)
        {
            foreach (Object customer in m_ListOfCustomerOfTheGarage)
            {
                while (!(customer.GetSetNumberOfLicensing.Equals(i_NumberOfLicensing) || i_Status is Customer.eStatus))
                {
                    Console.WriteLine("the input it is not good, we cant change the status");
                }
                while (customer.GetSetNumberOfLicensing.Equals(i_NumberOfLicensing) || i_Status is Customer.eStatus)
                {
                    if (i_Status.Equals(Object.eStatus.fix))
                    {
                        customer.GetSetStatus = Customer.eStatus.fix;
                    }
                    else if (i_Status.Equals(Customer.eStatus.InRepair))
                    {
                        customer.GetSetStatus = Customer.eStatus.InRepair;
                    }
                    else
                    {
                        customer.GetSetStatus = Customer.eStatus.paidUp;
                    }
                }
            }
        }
        

        public void FillWheels(string i_NumberOfLicensing)
        {
            foreach (Customer customer in m_ListOfCustomerOfTheGarage)
            {
                if (customer.GetSetNumberOfLicensing.Equals(i_NumberOfLicensing))
                {
                        customer.GetSetVehicle.SetMaxAirPressure();
                }
            }
        }


/*        public void FillFuel(string i_NumberOfLicensing, float i_HowMush, string i_Type)
        {
            try
            {
                foreach (Customer customer in m_ListOfCustomerOfTheGarage)
                {
                    if (customer.GetSetVehicle.TypeVehicle.Equals("FuelVhicle"))
                    {
                        if (customer.GetSetVehicle.TypeVehicle.FuelVh)
                        {

                        }
                    }
                    else
                    {
                        if (i_Type.Equals(m_TypeFuel))
                        {
                            base.GetSetCureentCapacity += i_HowMush;
                        }
                    }
                }
            }

            catch (ArgumentException)
            {
                Console.WriteLine("this input not fit to the fuel vehicle");
            }
        }*/

        public enum eFuel
        {
            Soler,
            Ocatan95,
            Octan96,
            Ocatn98
        }


    }

}
