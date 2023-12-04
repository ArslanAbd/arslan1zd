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
using static System.Math;
namespace arslanzd4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(numa.Text);
            double x = double.Parse(numx.Text);
            double b = double.Parse(numb.Text);
            double y = Pow(-a, 5) * x + b * Pow(Cos(Pow(x, 2)), 4) + b * x;
            double y1 = Sqrt(Abs(-a * x + y)) / Log(Abs(x + Pow(y, 2)));
            otv.Text = $"Ответ: Y = {y1}";
        }
    }
}
