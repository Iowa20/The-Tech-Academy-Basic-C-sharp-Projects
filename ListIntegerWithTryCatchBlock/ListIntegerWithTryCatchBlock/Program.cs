using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntegerWithTryCatchBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are the list in an array \nChoose a number in the list and divide that number from a number in the list.");
            List<int> ListInt = new List<int>() { 2, 4, 6, 8, 9, 10 };
            ListInt.ForEach(Console.WriteLine);
            Console.WriteLine("Choose a number from the list:");

            foreach (int numList in ListInt)
            {
                if (numList)


            }

       


        }
    }
}
