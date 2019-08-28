using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstName = new List<string>() { "Joe", "Charina", "Ed", "Joe" };
            List<string> lastName = new List<string>() { "Koy", "Dichoso", "Dichoso", "Parrot" };
            List<int> Id = new List<int>() { 10, 20, 30, 40, };

            foreach (string first in firstName)
            {
               if (first == "Joe")
                {
                    Console.WriteLine(first);
                }
            }
            Console.ReadLine();

        }
    }
}
