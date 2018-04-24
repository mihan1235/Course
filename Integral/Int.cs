using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    public class Int
    {
        public delegate double tf(double x);
        /*
         * {Integral variant 2}
         * Trapezium rule: I = In =  h(0.5*F_0+F_1+F_2+...+F_{n-1}+0.5*F_n),
         * где F_i = F(a+i*h), h=(b-a)/n 
        */

        public static double Integrate(tf f, double a, double b, double eps2)
        {
            int n, i;
            double sum, h, h1, x, s1, s2;
            n = 1;
            h = (b - a) / n;
            sum = (f(a) + f(b)) / 2;
            do
            {
                n = n * 2;
                h1 = h;
                h = h / 2;
                s1 = sum * h1;
                x = a + h;
                for (i = 1; i < n / 2; i++)
                {
                    sum = sum + f(x);
                    x = x + h1;
                }
                s2 = sum * h;
            } while (!(Math.Abs(s2 - s1) < eps2));
            return s2;
        }
    }
}
