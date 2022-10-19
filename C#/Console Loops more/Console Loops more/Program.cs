using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Loops_more
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Input a value");

            

            int Input = int.Parse(ReadLine());

            for (int i = 1; i < 10; i++)
            {

                WriteLine(Input +"*" + i +"="+ Input * i);

            }

            ReadLine();


            WriteLine("Input another value");

        }
    }
}
