using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21Ex_01_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write down three 9 digit binary number one by one");
            int firstNumberInBinary = CheckIfInputIsValid();
            int secondNumberInBinary = CheckIfInputIsValid();
            int thirdNumberInBinary = CheckIfInputIsValid();
            int firstDecimalNumber = ConvertBinaryToDecimal(firstNumberInBinary);
            int secondDecimalNumber = ConvertBinaryToDecimal(secondNumberInBinary);
            int thirdDecimalNumber = ConvertBinaryToDecimal(thirdNumberInBinary);
            Console.WriteLine("The numbers is: " + firstDecimalNumber + ", " + secondDecimalNumber + ", " + thirdDecimalNumber);
            Console.WriteLine("For the first number: " + BinartNumbersAvarageZerosAndOnes(firstNumberInBinary));
            Console.WriteLine("For the second number: " + BinartNumbersAvarageZerosAndOnes(secondNumberInBinary));
            Console.WriteLine("For the third number: " + BinartNumbersAvarageZerosAndOnes(thirdNumberInBinary));
            Console.WriteLine(NumbersArePowerOfTwo(firstDecimalNumber, secondDecimalNumber, thirdDecimalNumber));
            int howManySeriesAreInceasing = IncreasingSeries(firstDecimalNumber) + IncreasingSeries(secondDecimalNumber) + IncreasingSeries(thirdDecimalNumber);
            Console.WriteLine("There is " + howManySeriesAreInceasing + " numbers that are increasing series");
            Console.WriteLine("The biggest number is " + BiggestNumber(firstDecimalNumber, secondDecimalNumber, thirdDecimalNumber) + " and the smallest number is " + SmallestNumber(firstDecimalNumber, secondDecimalNumber, thirdDecimalNumber));
            Console.ReadLine();
        }


        private static int CheckIfInputIsValid()
        {
            int inputNumber;
            string inputString = System.Console.ReadLine();
            int.TryParse(inputString, out inputNumber);
            while (inputString == null || inputString.Length != 9 || inputNumber < 0 || CheckIfBinaryNumber(inputNumber) != true)
            {
                Console.WriteLine("Its not a 9 digit binary number, please right down one more time an valid 9 digit binary number");
                inputString = System.Console.ReadLine();
                int.TryParse(inputString, out inputNumber);
            }
            return inputNumber;
        }

        private static bool CheckIfBinaryNumber(int i_inputNumber)
        {
            while (i_inputNumber != 0)
            {
                if (i_inputNumber % 10 != 0 && i_inputNumber % 10 != 1)
                {
                    return false;
                }

                i_inputNumber /= 10;
            }
            return true;
        }

        private static int ConvertBinaryToDecimal(int i_binaryNumber)
        {
            int decimalNumber = 0;
            for (int i = 0; i < 9; i++)
            {
                if (i_binaryNumber % 10 == 1)
                {
                    decimalNumber += (int)Math.Pow(2, i);
                }

                i_binaryNumber /= 10;
            }

            return decimalNumber;
        }


        private static string BinartNumbersAvarageZerosAndOnes(int binaryNum)
        {
            string inputNumber = binaryNum.ToString();
            int ones = 0;
            int zeros = 0;
            foreach (char c in inputNumber)
            {
                if (c == '0')
                {
                    zeros++;
                }
                else
                {
                    ones++;
                }
            }
            string avargeZerosANdOnes = "Avarge zeros is " + zeros / 2 + " and avarege ones is " + ones / 2;
            return avargeZerosANdOnes;
        }

        private static string NumbersArePowerOfTwo(int firstDecimalNumber, int secondDecimalNumber, int thirdDecimalNumber)
        {
            int howManyNumberArePowerOfTwo = 0;
            if (firstDecimalNumber % 2 == 0)
            {
                howManyNumberArePowerOfTwo++;
            }
            if (secondDecimalNumber % 2 == 0)
            {
                howManyNumberArePowerOfTwo++;
            }
            if (thirdDecimalNumber % 2 == 0)
            {
                howManyNumberArePowerOfTwo++;
            }
            string theNumbersThatArePowerOfTwo = howManyNumberArePowerOfTwo + " out of 3 is powers of 2";
            return theNumbersThatArePowerOfTwo;
        }

        private static int IncreasingSeries(int i_decimalNumber)
        {
            int countingHowManyNumbersAreIncresingSeries = 0;
            int hundreds = i_decimalNumber / 100;
            int dozens = (i_decimalNumber / 10) - hundreds * 10;
            int oneness = i_decimalNumber - hundreds * 100 - dozens * 10;
            if (hundreds < dozens && dozens < oneness)
            {
                countingHowManyNumbersAreIncresingSeries++;
            }
            return countingHowManyNumbersAreIncresingSeries;
        }

        private static int BiggestNumber(int firstNumber, int secondNumber, int thiredNumber)
        {
            int biggestNumber = Math.Max(firstNumber, secondNumber);
            if (thiredNumber > biggestNumber)
            {
                biggestNumber = thiredNumber;
            }
            return biggestNumber;
        }

        private static int SmallestNumber(int firstNumber, int secondNumber, int thiredNumber)
        {
            int smallestNumber = Math.Min(firstNumber, secondNumber);
            if (thiredNumber < smallestNumber)
            {
                smallestNumber = thiredNumber;
            }
            return smallestNumber;
        }
    }
}
