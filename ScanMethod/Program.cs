using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanMethod
{
    class Program
    {
        static double func(double x)
        {
            return Math.Pow(100 - x, 2);
        }
        static void ScanMethod()
        {
            int iter = 0;
            double a = 60;
            double b = 150;
            double X = a;
            double h = 0.1;
            double Xopt = 0;
            double F = func(X);
            double R;

            Console.WriteLine($"iter = {iter}\tX = {X.ToString("0.000")}\tF = {F.ToString("0.000")}");

        M1: if (X < b)
            {
                X = X + h;
                R = func(X);
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
                Console.WriteLine($"\niter = {iter}\tXopt = {Xopt.ToString("0.000")}\tF = {func(Xopt).ToString("0.000")}");
            }
        }
        static void Main(string[] args)
        {
            ScanMethod();
        }
    }
}
