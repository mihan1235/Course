using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
//using Volter2;

namespace Course
{
    public class MainViewModel

    {

        public MainViewModel()

        {

            this.MyModel = new PlotModel { Title = "Test 2" };
            Func<double, double> g_t_exact = (t) => t - Math.Pow(t,2)/2;

            this.MyModel.Series.Add(new FunctionSeries(g_t_exact, 0, 5, 1.0, "g(t) = t - t^2/2"));
            
            //VolterII integral = new VolterII();
            //integral.GridSpacing = 0.01;
            //integral.SetTimeRange(0, 5);
            //var ans = integral.Solve();

            //LineSeries LineSeries1 = new LineSeries();
            //for(int i =0; i<ans.g.Count;i++)
            //{
            //    LineSeries1.Points.Add(new DataPoint(ans.t[i],ans.g.ElementAt(i)));
            //}
            //LineSeries1.Title = "ans";
            //this.MyModel.Series.Add(LineSeries1);

        }



        public PlotModel MyModel { get; private set; }

    }
}
