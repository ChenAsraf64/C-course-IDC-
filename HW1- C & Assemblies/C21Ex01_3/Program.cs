using System;
using System.Text.RegularExpressions;

namespace C21Ex01_3
{
    class Program
    {
        static int height;
        public static void Main(string[] args)
        {
            Console.WriteLine("Please right here desired height for hourlass");
            string input = CheckIfInputIsValid();
            int convertInputAsNumber = int.Parse(input);
            height = convertInputAsNumber;
            int result = TopHalfHourglass(convertInputAsNumber, height);
            int startingPointForBottomMethod = 2;
            if (height % 2 != 0)
            {
                startingPointForBottomMethod = 3;
            }
            int result1 = BottonHalfHourglass(startingPointForBottomMethod, height);

            Console.ReadLine();
        }

        public static string CheckIfInputIsValid()
        {
            string inputString = Console.ReadLine();
            while (!Regex.IsMatch(inputString, "^[0-9]*$"))
            {
                Console.WriteLine("Its not valid input, please right down only numbers that you want as an height for hourglass");
                inputString = System.Console.ReadLine();
            }

            return inputString;
        }

        public static int TopHalfHourglass(int i_heightNumber, int i_originalHeight)
        {
            string stars = "";
            if (i_heightNumber == 1 || i_heightNumber == 0)
            {
                for (int i = 0; i < i_originalHeight / 2; i++)
                {
                    stars += " ";
                }
                if (i_originalHeight % 2 == 0)
                {
                    Console.WriteLine(stars);
                    Console.WriteLine(stars);
                }
                else
                {
                    Console.WriteLine(stars + "*");
                }
            }
            else
            {
                for (int i = 0; i < (i_originalHeight - i_heightNumber) / 2; i++)
                {
                    stars += " ";
                }
                for (int i = 0; i < i_heightNumber; i++)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
                return TopHalfHourglass(i_heightNumber - 2, height);
            }
            return 0;
        }

        public static int BottonHalfHourglass(int startyHeight, int i_originalHeight)
        {
            string stars = "";
            if (startyHeight == i_originalHeight)
            {
                for (int i = 0; i < i_originalHeight; i++)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
            }
            else
            {
                for (int i = 0; i < (i_originalHeight - startyHeight) / 2; i++)
                {
                    stars += " ";
                }
                for (int i = 0; i < startyHeight; i++)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
                return BottonHalfHourglass(startyHeight + 2, height);
            }
            return 0;
        }
    }
}
