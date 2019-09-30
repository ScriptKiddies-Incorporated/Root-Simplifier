using System;
using System.Threading;

namespace Root_Simplifier
{
    class Program
    {
        static void Main()
        {
        A:
            int exponent, multi = 0 , last_digit;
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
            last_digit = exponent % 10;

             switch(last_digit)
            {
                case 0:
                    Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ")");
                    break;
                case 1:
                    Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "st root of (" + "" + value + ")");
                    break;
                case 2:
                    Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "nd root of (" + "" + value + ")");
                    break;
                case 3:
                    Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "rd root of (" + "" + value + ")");
                    break;

            }
            if(last_digit >=4 && last_digit <= 9)
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
