using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalDerivative
{
    public  class Derivative
    {
        public delegate double tf(double op);

        public static double FirstDerivative(tf f,double x, double h)
        {
            return (f(x + h) - f(x)) / h;
        }

        public static double SecondDerivative(tf f, double x, double h)
        {
            return (f(x) - 2*f(x+h) + f(x + 2*h)) / Math.Pow(h, 2);
        }
    }
}
