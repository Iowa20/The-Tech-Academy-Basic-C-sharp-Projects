using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Enter a number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("This displays an input number multiply by 50 = " + x * 50);

            int total = x + 25;
            Console.WriteLine("This displays an input number added by 25 = " + total);



            double quotient = x / 12.5;
            Console.WriteLine("This displays an input number divided by 12.5 = " + quotient);



            bool trueOrFalse = x > 50;
            Console.WriteLine("This displays if the input number is Greater than 50 = " + trueOrFalse.ToString());

            int remainder = x % 7;
            Console.WriteLine("This displays an input number divided by 7 and displays the remainder = " + remainder);

            Console.ReadLine();


        }
    }
}
