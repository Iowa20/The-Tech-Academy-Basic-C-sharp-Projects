using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrillPage156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Current Date & Time: " + now);

            int Num1;
            Console.WriteLine("Please enter any number:  ");
            Num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(string.Format("{0:HH:mm:ss tt}", DateTime.Now, + Num1));
            
            
           





            Console.ReadLine();
        }
    }
}
