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



            string Dui = null;
            Console.WriteLine("Have you ever had a DUI?");
            Dui = Console.ReadLine();

            if (Dui == "no")
                
            {
                Console.WriteLine("False");
            }
            else if (Dui == "yes")
            {
                Console.WriteLine("");
            }





            Console.WriteLine("How many speeding tickets do you have?");
            int y;


            y = int.Parse(Console.ReadLine());
            bool yesOrNo = y <= 3;
            

            Console.ReadLine();


            if (x >= 15)
               if (Dui == "no")
                    if (y <= 3)
                        
                    {
                        Console.WriteLine("Qualified!!!");
                    }
                  
            

            else if (y >= 3)
                {
                    Console.WriteLine("Unqualified!!!");
                }

            
            
                else if (Dui == "yes")
                {
                    Console.WriteLine("Unqualified!!!");
                }
            if (x < 15)
            {
                Console.WriteLine("Unqualified!!!");
            }




            Console.ReadLine();

        }
    }
}
