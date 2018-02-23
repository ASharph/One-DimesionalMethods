using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionMethods
{
    class ScanMethod
    {
        public static double FindMin(double a, double b)
        {
            int iter = 0;
            double X = a;
            double h = 0.1;
            double Xopt = 0;
            double F = Program.func(X);
            double R;


        M1: if (X < b)
            {
                X = X + h;
                R = Program.func(X);

                if (R < F)
                {
                    F = R;
                    Xopt = X;
                }

                iter++;

                goto M1;
            }
            else
            {                
                return Program.func(Xopt);
            }
        }
        static void ScanMethVisual()
        {
            int iter = 0;
            double a = 60;
            double b = 150;
            double X = a;
            double h = 0.1;
            double Xopt = 0;
            double F = Program.func(X);
            double R;

            Console.WriteLine($"iter = {iter}\tX = {X.ToString("0.000")}\tF = {F.ToString("0.000")}");

        M1: if (X < b)
            {
                X = X + h;
                R = Program.func(X);

                if (R < F)
                {
                    F = R;
                    Xopt = X;
                }

                iter++;

                Console.WriteLine($"iter = {iter}\tX = {X.ToString("0.000")}\tF = {R.ToString("0.000")}");
                goto M1;
            }
            else
            {
                Console.WriteLine($"\niter = {iter}\tXopt = {Xopt.ToString("0.000")}\tF = {Program.func(Xopt).ToString("0.000")}");
            }
        }
    }
}
