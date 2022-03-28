using System;
using System.Text.RegularExpressions;

namespace C21Ex01_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write down 8 charecters word that contain only English charecters or only numbers");
            string input = CheckIfInputIsValid();
            if (IsPolidrom(input))
            {
                Console.WriteLine("Your input is Polindrom");
            }
            else
            {
                Console.WriteLine("Your input is not Polindrom");
            }
            if (!CheckIfNumberOrEnglishCharecters(input))
            {
                Console.WriteLine(DivideByFour(input));
            }
            else
            {
                Console.WriteLine(HowManyUpperCases(input));
            }
            Console.ReadLine();

        }

        public static string CheckIfInputIsValid()
        {
            string inputString = Console.ReadLine();
            while ((!Regex.IsMatch(inputString, "^[a-zA-Z]*$") && !Regex.IsMatch(inputString, "^[0-9]*$")) || inputString.Length != 8)
            {
                Console.WriteLine("Its not valid input, Please write down 8 charecters word that contain only English charecters or only numbers");
                inputString = System.Console.ReadLine();
            }

            return inputString;
        }
        public static bool IsPolidrom(string i_input)
        {
            string reverseInput = "";
            for (int i = i_input.Length - 1; i >= 0; i--)
            {
                reverseInput += i_input[i].ToString();
            }
            if (reverseInput == i_input)
            {
                return true;
            }
            return !true;
        }

        public static string DivideByFour(string i_inputNumber)
        {
            int convertInputToInt = int.Parse(i_inputNumber);
            if (convertInputToInt % 4 == 0)
            {
                return "The number that you wrote down is divided by 4";
            }
            return "The number that you wrote down is't divided by 4";
        }

        public static bool CheckIfNumberOrEnglishCharecters(string i_inputString)
        {
            int countChars = 0;
            int countDigits = 0;
            foreach (char c in i_inputString)
            {
                if (char.IsDigit(c))
                {
                    countDigits++;
                }
                else
                {
                    countChars++;
                }
            }
            if (countChars == 8)
            {
                return true;
            }
            return false;
        }

        public static string HowManyUpperCases(string i_inputString)
        {
            int upperCasesCounting = 0;
            foreach (char c in i_inputString)
            {
                if (char.IsUpper(c))
                {
                    upperCasesCounting++;
                }
            }
            return "There is " + upperCasesCounting + " uppercasses";
        }
    }
}
