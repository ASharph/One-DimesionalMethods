using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionMethods
{
    class DivideByHalfMethod
    {
        public static double FindMin(double a, double b)
        {
            int iter = 0;
            double e = 0.001;
            double Xopt = 0;
            while(Math.Abs(a - b) >= 2 * e)
            {
                double x1 = (a + b - e) / 2;
                double x2 = (a + b + e) / 2;
                if (Program.func(x1) < Program.func(x2))
                {
                    b = x2;                    
                }
                else
                {
                    a = x1;                    
                }

                iter++;
            }

            Xopt = (a + b) / 2;
            //Console.WriteLine($"iter = {iter}\tXopt = {Xopt}\tF={Program.func(Xopt).ToString("0.000")}");

            return Program.func(Xopt);
        }
    }
}
