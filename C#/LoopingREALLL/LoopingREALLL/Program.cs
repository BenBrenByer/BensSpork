using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace LoopingREALLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lower = 0;
            int upper = 0;

            //WriteLine("Enter a low number");
            //lower = int.Parse(ReadLine());
            //WriteLine(lower);
            //WriteLine("Enter a higher number");
            //upper = int.Parse(ReadLine());
            //WriteLine(upper);

            WriteLine("\n");
            // count up using ++                                  1-100 by 1's
            //for (int i = 1; i <= 100; i++)
            //{
            //    WriteLine(i);
            //}

            //// count down using --          down by 1's
            ////for (int i = lower; i >= upper; i--)
            ////{
            ////    WriteLine(i);
            ////}

            ////WriteLine("\n");
            //// count by 2's                 up by 2's
            ////for (int i = lower; i <= upper; i+=2)
            ////{
            ////    WriteLine(i);
            ////}

            //WriteLine("\n");
            ////                                           50-0 by 1's
            //for (int i = 50; i >= 1; i--)
            //{
            //    WriteLine(i);
            //}

            //WriteLine("\n");
            ////                                           100-200 by 5's
            //for (int i = 100; i <= 200; i += 5)
            //{
            //    WriteLine(i);
            //}

            //WriteLine("\n");
            //                                           20 - -20 by 1's
            //for (int i = 20; i >= -20; i--)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    WriteLine(i);
            //}

            WriteLine("1." + "\n" + "------------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 11; j++)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine("2." + "----------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine("3." + "----------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < 6-i; j++)
                {
                    Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine("4." + "----------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < 6 - i; j++)
                {
                    Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Write("*");
                }

                

                for (int j = 2; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine("5." + "----------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < 6 - i; j++)
                {
                    Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Write(i);
                }



                for (int j = 2; j <= i; j++)
                {
                    Write(i);
                }
                WriteLine();
            }

            WriteLine("6." + "----------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < 6 - i; j++)
                {
                    Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Write(1+i-j);
                }
                    


                for (int j = 2; j <= i; j++)
                {
                    Write(j);
                }
                WriteLine();
            }

            WriteLine("\n \n \n \n \n \n \n \n \n" + "Assignment 2:" + "\n" + "1." + "----------------------------------------------------------------------------------------------------------------------");
            
            WriteLine("Input a value");

                ReadLine();

                int Input = int.Parse(ReadLine());

            for (int i = 1; i < 10; i++)
            {

                Write(Input + i + Input * i);

            }

            ReadLine();
        }
    }
}