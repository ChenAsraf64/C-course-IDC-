using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void ClickInvoker();

    public class Button : MenuFrame
    {
        public event ClickInvoker m_ClickInvoker;

        public Button(string i_Text)
        {
            base.GetSetTitle = i_Text;
        }

        public void Draw()
        {
            Console.WriteLine(base.GetSetTitle);
            this.OnClicked();
        }

        protected virtual void OnClicked()
        {
            if (m_ClickInvoker != null)
            {
                m_ClickInvoker.Invoke();
            }
        }
    }
}
