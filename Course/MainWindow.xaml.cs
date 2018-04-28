using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InverseProblem;

namespace Course
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //InverseProblem1 task = new InverseProblem1();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, RoutedEventArgs e)
        {
            var task = (InverseProblem1)this.FindResource("InverseProblem1");
            task.PhiInpit = PhiX.Text;
            task.PsiInpit = PsiX.Text;
            task.FInpit = FX.Text;
            task.PInpit = PT.Text;
            task.X0 = double.Parse(x0.Text);
            task.A = double.Parse(a.Text);
            task.T0 = double.Parse(t0.Text);
            task.T1 = double.Parse(t1.Text);
            task.GridSpacing = double.Parse(GridSpace.Text);
            List<double> g;
            double[] t;
            task.Solve(out g, out t);
            var Model = (MainViewModel)this.DataContext;
            Model.UpdateModel(g,t);
            //Model.TestModel(task.Phi);
        }
    }
}
