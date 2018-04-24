using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volter2
{

    public class VolterII
    {
        double h = 0.02f;
        public double GridSpacing
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }
        double a = 2.0f;
        double b = 3.0f;
        public void SetTimeRange(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public delegate double function2(double op1, double op2);
        public function2 K
        {
            get; set;
        }

        //double K(double t, double tau)
        //{
        //    return Math.Exp(t - tau);
        //}

        public delegate double function1(double op1);
        public function1 F
        {
            get; set;
        }
        //double F(double t)
        //{
        //    return t;
        //}

        int num;

        double lambda = 1;

        public double Lambda
        {
            get
            {
                return lambda;
            }
            set
            {
                lambda = value;
            }
        }


        public void Solve(out List<double> g, out double[] t)
        {
            g = new List<double>();
            t = new double[(int)((b - a) / h + 1)];
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            num = (int)((b - a) / h + 1);
            //Console.WriteLine(num);
            double tmp = a;
            for (int i = 0; i < num; i = i + 1)
            {

                t[i] = tmp;
                tmp += h;
            }

            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("[t{0}: {1} ]", i, t[i]);
            //}
            //Console.WriteLine();

            double y0 = F(t[0]);
            g.Add(y0);

            for (int i = 1; i < num; i = i + 1)
            {
                double sum = 0;
                for (int k = 0; k < i - 1; k++)
                {
                    sum = sum + K(t[i], t[k]) * g.ElementAt(k) * h;
                }
                double last_y = F(t[i]) - lambda * sum;
                g.Add(last_y);
            }
        }
    }
}
