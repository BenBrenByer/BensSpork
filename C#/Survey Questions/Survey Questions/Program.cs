using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string player;
            string a;
            string b;

            Console.WriteLine(@"What is Nick Cage's Favorite Color?" + "\n \n A. Red \n \n B. Blue \n \n C. Green \n \n D. Purple");

            player = (Console.ReadLine());

            Console.WriteLine(player);
            

            if (player == "A")
            {
                x = x + 1;
                Console.WriteLine("\n \n This is Correct. \n \n");
            }
            else
            {
                Console.WriteLine("\n \n This is Wrong. \n \n");
            }





            Console.WriteLine(@"What is Nick Cage's Favorite Animal?" + "\n \n A. Monkey \n \n B. Seal \n \n C. Giraffe \n \n D. Mole Rat");

            a = (Console.ReadLine());

            Console.WriteLine(player);


            if (a == "A")
            {
                x = x + 1;
                Console.WriteLine("\n \n This is Correct. \n \n");
            }
            else
            {
                Console.WriteLine("\n \n This is Wrong. \n \n");
            }





            Console.WriteLine(@"What is Nick Cage's Favorite Movie?" + "\n \n A. MoonStruck \n \n B. Pig \n \n C. The Unbearable Weight of Massive Talent \n \n D. Other Nick Cage Movie");

            b = (Console.ReadLine());

            Console.WriteLine(player);


            if (b == "B")
            {
                x = x + 1;
                Console.WriteLine("\n \n This is Correct. \n \n");
            }
            else
            {
                Console.WriteLine("\n \n This is Wrong. \n \n");
            }

            if (x == 3)
            {
                Console.WriteLine("\n \n You Got Everything Right! \n \n");
            }

            if (x == 2)
            {
                Console.WriteLine("\n \n You Got 1 Wrong. \n \n");
            }

            if (x == 1)
            {
                Console.WriteLine("\n \n You Got 2 Wrong. \n \n");
            }

            if (x == 0)
            {
                Console.WriteLine("\n \n You Got Everything Wrong You Uncultured Swine. \n \n");
            }


            a = (Console.ReadLine());
            
            Console.WriteLine(player);
            Console.WriteLine(@"Nick Cage's favorite color is {0}.", a);
            Console.WriteLine(@"Nick Cage's favorite color is {0}.", player);
            Console.WriteLine(@"Nick Cage's favorite color is {0}.", player);

            Console.ReadKey();
        }
    }
}
