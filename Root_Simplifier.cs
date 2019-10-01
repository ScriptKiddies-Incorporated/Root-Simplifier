using System;
using System.Threading;

namespace Root_Simplifier
{
    class Program
    {
        static void Main()
        {
        A:
            int exponent, multi = 0, last_digit;
            double value;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Root Simplifier 1.0");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Specify the radical exponent:");
            try
            {
                exponent = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enter only numbers, please!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }
            if (exponent <= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enter only positive numbers, please!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Specify a value under the radical sign!");
            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enter only numbers, please!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }
            if (exponent % 2 != 0 && value < 0)
            {
                for (int i = 1; i <= - value; i++)
                {
                    if (value % Math.Pow(i, exponent) == 0)
                    {
                        multi = i;
                    }

                }
            }
            else
            {
                for (int i = 1; i <= value; i++)
                {
                    if (value % Math.Pow(i, exponent) == 0)
                    {
                        multi = i;
                    }

                }
            }


            value = value / Math.Pow(multi, exponent);
            last_digit = exponent % 10;
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (last_digit)
            {
                case 0:
                    if (exponent % 2 == 0 && value < 0)
                    {
                        Console.WriteLine("There is no solution!");
                    }
                    if (exponent % 2 == 0 && value > 0)
                    {
                        if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                        {
                            Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ") = " + multi );
                        }
                        else
                        {
                            Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ")");
                        }
                    }
                    if ((exponent % 2 != 0 && value > 0) /*|| (exponent % 2 != 0 && value < 0)*/)
                    {
                        if ((exponent % 2 != 0 && value > 0) || (exponent % 2 != 0 && value < 0))
                        {
                            if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ") = " + multi);
                            }
                          /*  if ((-Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ") = -" + multi);
                            }
                          */
                            if ((-Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent) && (Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ")");
                            }
                        }
                    }
                     break;
                 case 1:
                     if (exponent % 2 == 0 && value < 0)
                     {
                         Console.WriteLine("There is no solution!");
                     }
                     if (exponent % 2 == 0 && value > 0)
                     {
                         if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                         {
                             Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "st root of (" + "" + value + ") = " + multi);
                         }
                         else
                         {
                             Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "st root of (" + "" + value + ")");
                         }
                     }
                     if ((exponent % 2 != 0 && value > 0) || (exponent % 2 != 0 && value < 0))
                     {
                        if ((exponent % 2 != 0 && value > 0) || (exponent % 2 != 0 && value < 0))
                        {
                            if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "st root of (" + "" + value + ") = " + multi);
                            }
                            if ((-Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "st root of (" + "" + value + ") = -" + multi);
                            }
                            if ((-Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent) && (Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "st root of (" + "" + value + ")");
                            }
                        }
                    }
                     break;
                 case 2:
                     if (exponent % 2 == 0 && value < 0)
                     {
                         Console.WriteLine("There is no solution!");
                     }
                     if (exponent % 2 == 0 && value > 0)
                     {
                         if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                         {
                             Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "nd root of (" + "" + value + ") = " + multi );
                        }
                         else
                         {
                             Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "nd root of (" + "" + value + ")");
                         }
                     }
                     if ((exponent % 2 != 0 && value > 0) /*|| (exponent % 2 != 0 && value < 0)*/)
                     {
                        if ((exponent % 2 != 0 && value > 0) || (exponent % 2 != 0 && value < 0))
                        {
                            if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "nd root of (" + "" + value + ") = " + multi);
                            }
                          /*  if ((-Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "nd root of (" + "" + value + ") = -" + multi);
                            }
                          */
                            if ((-Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent) && (Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "nd root of (" + "" + value + ")");
                            }
                        }
                    }
                    break;
                case 3:
                    if (exponent % 2 == 0 && value < 0)
                    {
                        Console.WriteLine("There is no solution!");
                    }
                    if (exponent % 2 == 0 && value > 0)
                    {
                        if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                        {
                            Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "rd root of (" + "" + value + ") = " + multi);
                        }
                        else
                        {
                            Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "rd root of (" + "" + value + ")");
                        }
                    }
                    if ((exponent % 2 != 0 && value > 0) || (exponent % 2 != 0 && value < 0))
                    {
                            if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "rd root of (" + "" + value + ") = " + multi);
                            }
                            if ((-Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "rd root of (" + "" + value + ") = -" + multi);
                            }
                            if ((-Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent) && (Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent))
                            {
                                Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "rd root of (" + "" + value + ")");
                            }
                    }
                    break;

            }
            if (last_digit >= 4 && last_digit <= 9)
            {
                if (exponent % 2 == 0 && value < 0)
                {
                    Console.WriteLine("There is no solution!");
                }
                if (exponent % 2 == 0 && value > 0)
                {
                    if ( (Math.Pow(multi,exponent)) == value * Math.Pow(multi, exponent))
                    {
                       Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ") = " + multi );
                    }
                    else
                    {
                        Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ")");
                    }
                }
                if ((exponent % 2 != 0 && value > 0) || (exponent % 2 != 0 && value < 0))
                {
                    if ((exponent % 2 != 0 && value > 0) || (exponent % 2 != 0 && value < 0))
                    {
                        if ((Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                        {
                            Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ") = " + multi);
                        }
                        if ((-Math.Pow(multi, exponent)) == value * Math.Pow(multi, exponent))
                        {
                            Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ") = -" + multi);
                        }
                        if ((-Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent) && (Math.Pow(multi, exponent)) != value * Math.Pow(multi, exponent))
                        {
                            Console.WriteLine("Simplified expression = " + multi + " x " + exponent + "th root of (" + "" + value + ")");
                        }
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            goto A;
        }
    }
}
