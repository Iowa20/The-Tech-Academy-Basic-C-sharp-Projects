using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Countdown: 20 to 0");
            int x = 20;
            Console.ReadLine();
            do
            {
                Console.WriteLine("Countdown:" + x);
                x--;
            } while (x > 0);

            Console.ReadLine();
        }
    }
}
