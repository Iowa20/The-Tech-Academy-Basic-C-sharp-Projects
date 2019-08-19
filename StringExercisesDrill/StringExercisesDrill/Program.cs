using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercisesDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " Edmund Dichoso \n I'm a Full-satack Developer";
            string info2 = " and a graduate of The Tech Academy,";
            string info3 = " Portland, Oregon.";

            name = name.ToUpper();

            Console.WriteLine(name + info2 + info3);


            StringBuilder sb = new StringBuilder();
            sb.Append(" My name is Edmund Dichoso.");
            sb.AppendLine(" I'm a software developer. ");
            sb.AppendLine(" I'm also a Brazilian Jiu Jitsu practioner.\n My life revolves around travelling, hiking and working out with my wife.\n");
            sb.AppendLine(" I believe that life should be simple and meaningful.");
            sb.AppendLine(" Reach your dreams by taking the risk and take full responsibility of your actions.");
            sb.AppendLine(" Fear is what will hold us back, so take that chance. So that, you will live life without regret.");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
