using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IToAlert
    {
        public void LetMenuKnow()
        {
            ShowTime.showTime();
        }

        public static void showTime()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("the time is:" + time.ToString("t"));
        }
    }
}
