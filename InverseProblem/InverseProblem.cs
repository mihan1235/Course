using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grammar;
using Volter2;

namespace InverseProblem
{
    public class InverseProblem : ISetTimeRange, IGridSpacing
    {
        VolterII integral = new VolterII();

        public double GridSpacing
        {
            get
            {
                return integral.GridSpacing;
            }
            set
            {
                integral.GridSpacing = value;
            }
        }

        public void SetTimeRange(double a, double b)
        {
            integral.SetTimeRange(a, b);
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

    }        
}
