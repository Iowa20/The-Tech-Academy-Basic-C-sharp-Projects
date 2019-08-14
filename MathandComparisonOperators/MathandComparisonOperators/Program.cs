using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program:");
            
           

            

            Console.WriteLine("Person 1");
            int hourlyRate1;
            Console.WriteLine("Input Hourly Rate:");
            hourlyRate1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Hourly Rate:" + hourlyRate1);
           
            Console.WriteLine("Hours worked per week:" + 40);
           
            Console.ReadLine();

            Console.WriteLine("Person 2");
            int hourlyRate2;
            Console.WriteLine("Input Hourly Rate:");
            hourlyRate2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hourly Rate:" + hourlyRate2);
            Console.WriteLine("Hours worked per week:" + 40);
            Console.ReadLine();

            Console.WriteLine("Weekly Salary of Person 1:" + hourlyRate1 * 40);
            Console.WriteLine("Weekly Salary of Person 2:" + hourlyRate2 * 40);

            bool trueOrFalse = hourlyRate1 > hourlyRate2;

            Console.WriteLine("Does Person 1 make more money than Person 2? " + trueOrFalse.ToString());

          
           
            
            Console.ReadLine();


        }

    }
}
