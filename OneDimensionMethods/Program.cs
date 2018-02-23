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
            Console.WriteLine(ScanMethod.FindMin(60, 150).ToString("0.0000"));
            Console.WriteLine(DivideByHalfMethod.FindMin(60, 150).ToString("0.0000"));
        }
        public static double func(double x)
        {
            return Math.Pow(100 - x, 2);
        }
    }
}
