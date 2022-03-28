using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IToAlert
    {
        public void LetMenuKnow()
        {
            ShowDate.showDate();
        }

        public static void showDate()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("the date is:" + date.Date.ToString("MM/dd/yyyy"));
        }
    }
}
