using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionMethods
{
    class GoldenSection
    {
        public static double FindMin(double a, double b)
        {
            int iter = 0;
            double e = 0.01;
            double Xopt = 0;
            double x1 = a + 0.382d * (b - a);
            double x2 = a + 0.618d * (b - a);

            while(Math.Abs(a - b) > e)
            {
                if (Program.func(x1) >= Program.func(x2))
                {
                    a = x1;
                    x1 = x2;
                    x2 = a + 0.618d * (b - a);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + 0.382 * (b - a);
                }

                iter++;
            }

            Xopt = (a + b) / 2;
            //Console.WriteLine($"iter = {iter}\tXopt = {Xopt}\tF={Program.func(Xopt).ToString("0.000")}");

            return Program.func(Xopt);
        }
    }
}
