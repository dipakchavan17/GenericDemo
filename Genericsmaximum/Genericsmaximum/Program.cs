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
            /*
            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(23, 43, 65);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);
            Console.WriteLine("Finding max Number :");

            string maximum1 = MaximumNumberCheck.FindMaximum<int>(29, 76, 94);
            string maximum2 = MaximumNumberCheck.FindMaximum<float>(231.2f, 112.45f, 32.56f);
            string maximum3 = MaximumNumberCheck.FindMaximum<string>("202", "323", "441");

            Console.WriteLine(maximum1);
            Console.WriteLine(maximum2);
            Console.WriteLine(maximum3);
            */
            /* Console.WriteLine("Finding max Number :");

             string maximum1 = MaximumNumberCheck.FindMaximum<int>(29, 76, 94);
             string maximum2 = MaximumNumberCheck.FindMaximum<float>(231.2f, 112.45f, 32.56f);
             string maximum3 = MaximumNumberCheck.FindMaximum<string>("202", "323", "441");

             Console.WriteLine(maximum1);
             Console.WriteLine(maximum2);
             Console.WriteLine(maximum3);
            */
            Console.WriteLine("Finding max Number :");

            int[] intArray = { 242, 112, 912, 220, 178 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 21.2, 34.4, 14.32, 25.5, 16.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "101", "422", "233", "552", "109" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();



            Console.ReadLine();
        }
    }
}
