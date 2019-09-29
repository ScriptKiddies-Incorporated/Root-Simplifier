using System;
using System.Threading;

namespace Root_Simplifier
{
    class Program
    {
        static void Main()
        {
        A:
            int exponent, multi = 0 ;
            double value; 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Root Simplifier 1.0");
            Console.WriteLine("Enter exponetial number!");
            try
            {
                exponent = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Enter only numbers , please!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }
            if (exponent <= 0)
            {
                Console.WriteLine("Enter only positive numbers, please!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }
            Console.WriteLine("Enter the value under the root!");
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
                    if (value % Math.Pow(i,exponent) == 0)
                    {
                        multi = i;
                    }

                }

            value = value / Math.Pow(multi, exponent);
            Console.WriteLine("number = " + multi + "  " + exponent + " rt " + "" + value);

            Console.ReadKey();
            Console.Clear();
            goto A;
        }
    }
}
