using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuToMain
    {
        private MenuFrame m_MainMenu;
        public MenuToMain()
        {
            MenuFrame main = new MenuFrame("main menu:");
            m_MainMenu = main;
        }

        public void AddSupMenu(MenuFrame i_SupMenu)
        {
            m_MainMenu.GetSetListMenus.Add(i_SupMenu);
        }
        public void AddButton(Button i_button)
        {
            m_MainMenu.GetSetListMenus.Add(i_button);
        }

        public void ShowMenu()
        {
            int option = 1;
            Console.WriteLine(ToString());
            option = GetOpionFromUser();
            while (m_MainMenu.GetSetHeadMenu != null || option != 0)
            {
                Console.Clear();

                if (option == 0)
                {
                    m_MainMenu = m_MainMenu.GetSetHeadMenu;
                }
                else
                {
                    if (m_MainMenu.GetSetListMenus.ElementAt(option - 1) is Button)
                    {
                        Button button = m_MainMenu.GetSetListMenus.ElementAt(option - 1) as Button;
                        button.Draw();
                        Console.WriteLine("Press ENTER to get back to the menu.");
                        Console.ReadLine();
                    }
                    else
                    {
                        MenuFrame NewHeadMenu = m_MainMenu;
                        m_MainMenu = (MenuFrame)m_MainMenu.GetSetListMenus.ElementAt(option - 1);
                        m_MainMenu.GetSetHeadMenu = NewHeadMenu;
                    }
                }

                Console.Clear();
                Console.WriteLine(ToString());
                option = GetOpionFromUser();
            }
        }


        private int GetOpionFromUser()
        {
            string UserInput = Console.ReadLine();
            int UserInputAsInt;
            int lenghtOfList = m_MainMenu.GetSetListMenus.Count;

            while (!int.TryParse(UserInput, out UserInputAsInt) || !(UserInputAsInt > -1 && UserInputAsInt < lenghtOfList + 1))
            {
                Console.Clear();
                Console.WriteLine("Choose an option 1-" + lenghtOfList + " or 0 to Exit");
                Console.WriteLine(ToString());
                UserInput = Console.ReadLine();
            }

            int.TryParse(UserInput, out UserInputAsInt);

            return UserInputAsInt;
        }

        public override string ToString()
        {
            StringBuilder MenuToPrint = new StringBuilder();
            MenuToPrint.Append(m_MainMenu.GetSetTitle);
            MenuToPrint.AppendLine();
            int index = 1;
            foreach (MenuFrame menu in m_MainMenu.GetSetListMenus)
            {
                MenuToPrint.AppendFormat("{0}: {1}", index, menu.GetSetTitle);
                MenuToPrint.AppendLine();
                index++;
            }

            if (m_MainMenu.GetSetHeadMenu == null)
            {
                MenuToPrint.AppendFormat("{0}: {1}", 0, "Exit");
            }
            else
            {
                MenuToPrint.AppendFormat("{0}: {1}", 0, "Back to the last menu");
            }

            MenuToPrint.AppendLine();
            MenuToPrint.AppendFormat("Choose 1 - {0} or 0 to Exit", m_MainMenu.GetSetListMenus.Count);


            return MenuToPrint.ToString();
        }

    }
}
