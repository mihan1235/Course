using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grammar;
using Volter2;
using Integral;
using NumericalDerivative;
using static NumericalDerivative.Derivative;
using static Integral.Int;

namespace InverseProblem
{
    public class InverseProblem
    {
        double h;
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

        double t0;
        double t1;

        public double T0
        {
            get
            {
                return t0;
            }
            set
            {
                t0 = value;
            }
        }

        public double T1
        {
            get
            {
                return t1;
            }
            set
            {
                t1 = value;
            }
        }

        public double X0
        {
            get;
            set;
        }

        public double A
        {
            get;
            set;
        }

        FunctionGrammar FX = new FunctionGrammar();
        FunctionGrammar PhiX = new FunctionGrammar();
        FunctionGrammar PsiX = new FunctionGrammar();

        public string FInpit
        {
            set
            {
                FX.Input = value;
            }
        }

        public double F(double x)
        {
            return FX.Func(x);
        }

        public string PhiInpit
        {
            set
            {
                PhiX.Input = value;
            }
        }

        public double Phi(double x)
        {
            return PhiX.Func(x);
        }

        public string PsiInpit
        {
            set
            {
                PsiX.Input = value;
            }
        }

        public double Psi(double x)
        {
            return PsiX.Func(x);
        }

        FunctionGrammar PT = new FunctionGrammar();

        public string PInpit
        {
            set
            {
                PT.Input = value;
            }
        }

        public double P(double t)
        {
            return PT.Func(t);
        }

        double p_1(double t)
        {
            double ans = P(t) - (Phi(X0 + A * t) + Phi(X0 - A * t)) / 2;
            ans -= 1 / (2 * A) * Integrate(Psi,X0 - A*t, X0 + A*t,h);
            return ans;
        }

        VolterII volter_int = new VolterII();

        public void Solve(out List<double> g, double[] t)
        {
            

            throw (new NotImplementedException());
        }
    }        
}
