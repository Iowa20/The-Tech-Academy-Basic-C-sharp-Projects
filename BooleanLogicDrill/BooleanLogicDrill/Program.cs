using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicDrill
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What is your age?");
            int x;
            
            
            x = int.Parse(Console.ReadLine());
            bool trueOrFalse = x >= 15;
            
            


            

            string dui = null;
            Console.WriteLine("Have you ever had a DUI?");
            dui = Console.ReadLine();
            if (dui == "no")
            {
                Console.WriteLine("You'll have an Insurance discount.");
            }
            else
            {
                Console.Write("Insurance rate may go up.");
            }
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int y;


            y = int.Parse(Console.ReadLine());
            bool yesOrNo = y <= 3;
            

            Console.ReadLine();


            if (x >= 15)
                if (dui == "no")
                    if (y <= 3)
                    {
                        Console.WriteLine("Qualified");
                    }
                    else
                    {
                        Console.WriteLine("Unqualified");
                    }




            Console.ReadLine();

        }
    }
}
