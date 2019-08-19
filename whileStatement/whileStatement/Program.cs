using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count 1 to 20:");
            
            int x = 1;

            while (x <= 20)
            {
                Console.WriteLine("Count: "+ x );
                x++;
                Console.ReadLine();
            }

        }

    }
}
