using System;
using System.Threading;

namespace Root_Simplifier
{
    class Program
    {
        static void Main()
        {
        A:
            int exponent, multi = 0;
            double value;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Root Simplifier 1.0");
            Console.WriteLine("Specify the radical exponent:");
            try
            {
                exponent = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter only numbers, please!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }
            if (exponent <= 1)
            {
                Console.WriteLine("Enter only positive numbers, please!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }
            Console.WriteLine("Specify a value under the radical sign!");
            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter only numbers, please!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }

            for (int i = 1; i <= value; i++)
            {
                if (value % Math.Pow(i, exponent) == 0)
                {
                    multi = i;
                }

            }

            value = value / Math.Pow(multi, exponent);

            if (exponent == 2)
            {
                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "nd root of (" + "" + value + ")");
            }
            else if (exponent == 3)
            {
                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "rd root of (" + "" + value + ")");
            }
            else
            {
                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ")");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            goto A;
        }
    }
}
