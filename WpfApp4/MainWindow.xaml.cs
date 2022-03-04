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

namespace WpfApp4
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
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            result.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resDouble = rateEuro * sumEuro;
            result1.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double ratePound = Convert.ToDouble(rate2.Text);
            double sumPound = Convert.ToDouble(sum2.Text);
            double resDouble = ratePound * sumPound;
            result2.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateUan = Convert.ToDouble(rate3.Text);
            double sumUan = Convert.ToDouble(sum3.Text);
            double resDouble = rateUan * sumUan;
            result3.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double lenDuim = Convert.ToDouble(lenD.Text);
            double resMeter = lenDuim / 39.3701;
            resLen.Text = resMeter.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double lenFoot = Convert.ToDouble(lenD1.Text);
            double resMeter = lenFoot / 3.28084;
            resLen1.Text = resMeter.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double lenMile = Convert.ToDouble(lenD2.Text);
            double resMeter = lenMile / 0.000621371;
            resLen2.Text = resMeter.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double lenSm = Convert.ToDouble(lenD3.Text);
            double resMeter = lenSm / 100;
            resLen3.Text = resMeter.ToString();
        }
    }
}
