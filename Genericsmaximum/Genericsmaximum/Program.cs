using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsmaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generic demo");

            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(23, 43, 65);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
