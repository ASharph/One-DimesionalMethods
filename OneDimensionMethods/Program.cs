using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Scan: {ScanMethod.FindMin(60, 150)}");
            Console.WriteLine($"Divide By Half: { DivideByHalfMethod.FindMin(60, 150)}");
            Console.WriteLine($"Golden Section: {GoldenSection.FindMin(60, 150)}");
        }
        public static double func(double x)
        {
            return Math.Pow(100 - x, 2);
        }
    }
}
