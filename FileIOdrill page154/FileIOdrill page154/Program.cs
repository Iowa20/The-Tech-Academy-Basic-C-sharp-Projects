using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileIOdrill_page154
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\nin_i\logs\log.txt";

            int Num;
            Console.WriteLine("Please, type a number.");
            Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number is: " + Num);
            Console.ReadLine();
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
