using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowVersion : IToAlert
    {
        public void LetMenuKnow()
        {
            ShowVersion.showVersion();
        }

        public static void showVersion()
        {
            Console.WriteLine("Version: 21.3.4.8933");
        }
    }
}
