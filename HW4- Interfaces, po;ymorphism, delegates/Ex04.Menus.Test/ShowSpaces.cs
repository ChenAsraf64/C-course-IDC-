using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowSpaces : IToAlert
    {
        public void LetMenuKnow()
        {
            ShowSpaces.showSpaces();
        }

        public static void showSpaces()
        {
            Console.WriteLine("please write a sentence, and we return the nummber of spaces in it.");
            string InputToCountSpaces = Console.ReadLine();

            while(InputToCountSpaces == null)
            {
                Console.WriteLine("please reat the sentence!");
                InputToCountSpaces = Console.ReadLine();
            }

            int count = 0;
            for (int i = 0; i < InputToCountSpaces.Length; i++)
            {
                if (InputToCountSpaces[i] == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("there are {0} spaces in the sentence", count);
        }
    }
}
