using System;


namespace C21Ex01_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int height = 5;
            Console.WriteLine("An hourglass at height " + height + " :");
            int result = TopHalfHourglass(height);
            int result1 = BottonHalfHourglass(height);
            Console.ReadLine();
        }

        public static int TopHalfHourglass(int i_heightNumber)
        {
            string stars = "";
            if (i_heightNumber != 1)
            {
                if (i_heightNumber != 5)
                {
                    stars += " ";
                }
                for (int i = 0; i < i_heightNumber; i++)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
                return TopHalfHourglass(i_heightNumber - 2);
            }
            stars += "  *";
            Console.WriteLine(stars);
            return 0;
        }

        public static int BottonHalfHourglass(int i_heightNumber)
        {
            int height = i_heightNumber - 2;
            string stars = " ";
            if (height != 5)
            {
                for (int i = 0; i < height; i++)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
                return BottonHalfHourglass(i_heightNumber + 2);
            }
            Console.WriteLine("*****");
            return 0;
        }
    }
}
