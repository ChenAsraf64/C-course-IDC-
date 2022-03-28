using System;
using System.Text.RegularExpressions;


namespace C21Ex01_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write down 9 digits");
            string input = CheckIfInputIsValid();
            Console.WriteLine("The biggest number is " + BiggestNumber(input));
            Console.WriteLine("The smallest number is " + SmallestNumber(input));
            Console.WriteLine("There are " + DivideByTree(input) + " numbers that divided by 3");
            Console.WriteLine("There are " + CountNumbersThatBiggerThenOneness(input) + " that bigger then oneness number");
        }

        public static string CheckIfInputIsValid()
        {
            string inputString = Console.ReadLine();
            while (!Regex.IsMatch(inputString, "^[0-9]*$") || inputString.Length != 9)
            {
                Console.WriteLine("Its not valid input, Please write down 9 digits");
                inputString = System.Console.ReadLine();
            }

            return inputString;
        }

        private static int BiggestNumber(string i_stringNumber)
        {
            int biggestNumber = i_stringNumber[0] - '0';
            foreach (char c in i_stringNumber)
            {
                if (c > biggestNumber)
                {
                    biggestNumber = c - '0';
                }
            }
            return biggestNumber;
        }

        private static int SmallestNumber(string i_stringNumber)
        {
            int smallestNumber = i_stringNumber[0] - '0';
            foreach (char c in i_stringNumber)
            {
                if (c < smallestNumber)
                {
                    smallestNumber = c - '0';
                }
            }
            return smallestNumber;
        }

        public static int DivideByTree(string i_inputNumber)
        {
            int countNumbersThatDividedByThree = 0;
            foreach (char c in i_inputNumber)
            {
                int convertToInt = c - '0';
                if (convertToInt % 3 == 0)
                {
                    countNumbersThatDividedByThree++;
                }
            }
            return countNumbersThatDividedByThree;
        }

        public static int CountNumbersThatBiggerThenOneness(string i_inputNumber)
        {
            int onenessNumber = i_inputNumber[8] - '0';
            int countNumbersBiggerNumbers = 0;
            foreach (char c in i_inputNumber)
            {
                int convertToInt = c - '0';
                if (convertToInt > onenessNumber)
                {
                    countNumbersBiggerNumbers++;
                }
            }
            return countNumbersBiggerNumbers;
        }
    }
}
