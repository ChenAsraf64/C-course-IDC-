using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{

    public class Button : MenuFrame
    {
        private List<IToAlert> m_ToAlert;

        public Button(string i_Text, IToAlert i_ToAlert)
        {
            base.GetSetTitle = i_Text;
            m_ToAlert = new List<IToAlert>();
            m_ToAlert.Add(i_ToAlert);
        }
        

        public void Clicked()
        {
            foreach(IToAlert toAlert in m_ToAlert)
            {
                toAlert.LetMenuKnow();
            }
        }

        public void Draw()
        {
            Console.WriteLine(base.GetSetTitle);
            foreach(IToAlert toAlert in m_ToAlert)
            {
                toAlert.LetMenuKnow();
            }
        }

        public List<IToAlert> GerSetToAlert
        {
            get { return m_ToAlert; }
            set { m_ToAlert = value; }
        }

        public void AddToAlert(IToAlert i_toAlert)
        {
            m_ToAlert.Add(i_toAlert);
        }
    }
}
