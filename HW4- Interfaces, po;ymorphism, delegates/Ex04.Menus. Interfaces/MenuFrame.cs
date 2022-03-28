using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuFrame
    {
        private string m_Titel;
        private List<MenuFrame> m_ListMenus;
        private MenuFrame m_HeadMenu;


        public MenuFrame()
        {
        }

        public MenuFrame(string i_Titel)
        {
            m_Titel = i_Titel;
            m_ListMenus = new List<MenuFrame>();
            m_HeadMenu = null;
        }

        public string GetSetTitle
        {
            get { return m_Titel; }
            set { m_Titel = value; }
        }

        public List<MenuFrame> GetSetListMenus
        {
            get { return m_ListMenus; }
            set { m_ListMenus = value; }
        }

        public MenuFrame GetSetHeadMenu
        {
            get { return m_HeadMenu; }
            set { m_HeadMenu = value; }
        }


        public void AddSubMenuToMenu(MenuFrame i_menu)
        {
            m_ListMenus.Add(i_menu);
        }

        public void AddButton(Button i_button)
        {
            m_ListMenus.Add(i_button);
        }

        public virtual void LetMenuKnow()
        {
        }


    }
}
