using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDrillExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an Index from 0 to 4.\nThen, the console will display the equivalent value of an index.");
            string[] stringArray = { "uno", "dos", "tres", "cuatro", "cinco", };

            int stringA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value is: " + stringArray[stringA]);

            

            Console.ReadLine();




           

            Console.WriteLine("Select an Index from 0 to 3. \nThen, the console will display the equivalent value of an index.");
            int[] NumArray = { 20, 25, 55, 45 };

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("value is: " + NumArray[input]);

            for (int inputB = 0; inputB > NumArray.Length; inputB++)
            {
                Console.WriteLine("It is outside the index of the Array!!!");
            }




            Console.ReadLine();
        }
    }
}
