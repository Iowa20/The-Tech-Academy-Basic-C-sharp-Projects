using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            

               if (packageWeight >= 51)
               
            {
                Console.Write("Package too big to be shipped via Package Express.");
            }
            

            Console.ReadLine();
            Console.WriteLine("Please enter width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter lenght:");
            int packageLenght = Convert.ToInt32(Console.ReadLine());

            int total = packageWidth + packageHeight + packageLenght;
            if (total >= 51)
            {
                
                Console.WriteLine("Package too big to be shipped via Pagkage Express");
            }
            else
            {
                Console.WriteLine();
            }

            Console.ReadLine();

            int shippingTotal = total * packageWeight % 100;
            
            
            
            {
               
                Console.WriteLine("{0:C} " + shippingTotal);
            }

            Console.WriteLine("Thank you.");
           
            Console.ReadLine();
        }
    }
}
