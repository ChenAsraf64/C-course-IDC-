using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        private eCarColors m_Color;
        private eEmountOfDoors m_Doors;
        private const int k_NumberOfWheels = 4;
        private const int k_WheelMaxPressure = 30;

        public Car()
        {
            // $G$ CSS-999 (-2) If you use number as condition --> then you should have use constant here.
            for (int i = 0; i < 4; i++)
            {
                Wheels wheelToAdd = new Wheels(k_WheelMaxPressure);
                base.Wheels.Add(wheelToAdd);
            }
            
        }

        public eCarColors SetGetColor
        {
            get { return m_Color; }
            set { m_Color = value;  }
        }

        public eEmountOfDoors SetGetDoors
        {
            get { return m_Doors; }
            set { m_Doors = value; }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("@color of the car: {0} \n nummber of doors: {1}\n nummber of wheels: {2} \n ",
                m_Color, m_Doors, k_NumberOfWheels);
        }

    }
    public enum eCarColors
    {
        Yellow = 1,
        White = 2,
        Black = 3,
        Blue = 4
    }

    public enum eEmountOfDoors
    {
        TwoDoors = 2,
        ThreeDoors = 3,
        FourDoors = 4,
        FiveDoors = 5
    }
}
