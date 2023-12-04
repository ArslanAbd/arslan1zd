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

namespace arslan3zd
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
            double b = double.Parse(numb.Text);
            double c = double.Parse(numc.Text);
            double d = Pow(b, 2) - a * a * c;
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);
            otv.Text = $"Ответ: меньший x = {Min(x1, x2)}\n больший x = {Max(x1, x2)}";
        }
    }
}
