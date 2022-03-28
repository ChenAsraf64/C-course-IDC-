using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    class SetMenu
    {
        public void start()
        {
            Console.WriteLine("Menu as Interface");
            SetInterfaceMenu();
            Console.Clear();

            Console.WriteLine("Menu as Delegates");
            SetDelegatesMenu();
            Console.Clear();
        }

        //interface

        public void SetInterfaceMenu()
        {
            Interfaces.MenuToMain menu = new Interfaces.MenuToMain();
            ShowSpaces spaces = new ShowSpaces();
            ShowVersion version = new ShowVersion();
            ShowDate date = new ShowDate();
            ShowTime time = new ShowTime();

            Interfaces.MenuFrame menu1 = new Interfaces.MenuFrame("Version and Spaces");
            Interfaces.Button spacesButton = new Interfaces.Button("Count Spaces", spaces);
            menu1.AddButton(spacesButton);
            Interfaces.Button versionButton = new Interfaces.Button("Show Version", version);
            menu1.AddButton(versionButton);


            Interfaces.MenuFrame menu2 = new Interfaces.MenuFrame("Show Date/Time");
            Interfaces.Button dateButton = new Interfaces.Button("Show Date", date);
            menu2.AddButton(dateButton);
            Interfaces.Button timeButton = new Interfaces.Button("Show Time", time);
            menu2.AddButton(timeButton);
            
            menu.AddSupMenu(menu1);
            menu.AddSupMenu(menu2);
            menu2.GetSetHeadMenu = menu1;
            menu1.GetSetHeadMenu = null;

            menu.ShowMenu();

        }

        // delegate
        public void SetDelegatesMenu()
        {
            Delegates.MenuToMain menu = new Delegates.MenuToMain();
            Delegates.MenuFrame menu1 = new Delegates.MenuFrame("Version and Spaces");
            Delegates.MenuFrame menu2 = new Delegates.MenuFrame("Show Date/Time");

            Delegates.Button spacesButton = new Delegates.Button("Count Spaces");
            spacesButton.m_ClickInvoker += new ClickInvoker(ShowSpaces.showSpaces);
            Delegates.Button versionButton = new Delegates.Button("Show Version");
            versionButton.m_ClickInvoker += new ClickInvoker(ShowVersion.showVersion);
            menu1.AddButton(spacesButton);
            menu1.AddButton(versionButton);

            Delegates.Button dateButton = new Delegates.Button("Show Date");
            dateButton.m_ClickInvoker += new ClickInvoker(ShowDate.showDate);
            Delegates.Button timeButton = new Delegates.Button("Show Time");
            timeButton.m_ClickInvoker += new ClickInvoker(ShowTime.showTime);
            menu2.AddButton(dateButton);
            menu2.AddButton(timeButton);

            menu.AddSupMenu(menu1);
            menu.AddSupMenu(menu2);

            menu.ShowMenu();
        }

    }
}
