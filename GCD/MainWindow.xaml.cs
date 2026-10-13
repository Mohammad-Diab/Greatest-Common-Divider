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

namespace GCD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            long n, m;
            long.TryParse(Number1.Text, out n);
            long.TryParse(Number2.Text, out m);
            if ((n > 9223372036854775807 || n < 2) || (m > 9223372036854775807 || m < 2))
                MessageBox.Show("Nubmers must be in this domin\n[2,9223372036854775807]", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                long m1 = DateTime.Now.Ticks;
                long gcd = GCD2(n, m);
                long m2 = DateTime.Now.Ticks;
                MessageBox.Show(String.Concat("Done in ", (((double)(m2 - m1)) / 10000).ToString(), " Millisocond\nGreatest common divisor is '", gcd, "'"), "Dr.Mohammad", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            long n, m;
            long.TryParse(Number1.Text, out n);
            long.TryParse(Number2.Text, out m);
            if ((n > 9223372036854775807 || n < 2) || (m > 9223372036854775807 || m < 2))
                MessageBox.Show("Nubmers must be in this domin\n[2,9223372036854775807]", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                long m1 = DateTime.Now.Ticks;
                long gcd = GCD3(n, m);
                long m2 = DateTime.Now.Ticks;
                MessageBox.Show(String.Concat("Done in ", (((double)(m2 - m1)) / 10000).ToString(), " Millisocond\nGreatest common divisor is '", gcd, "'"), "Dr.Mohammad", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            long n, m;
            long.TryParse(Number1.Text, out n);
            long.TryParse(Number2.Text, out m);
            if ((n > 9223372036854775807 || n < 2) || (m > 9223372036854775807 || m < 2))
                MessageBox.Show("Nubmers must be in this domin\n[2,9223372036854775807]", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                long m1 = DateTime.Now.Ticks;
                long gcd = GCD1(n, m);
                long m2 = DateTime.Now.Ticks;
                MessageBox.Show(String.Concat("Done in ", (((double)(m2 - m1)) / 10000).ToString(), " Millisocond\nGreatest common divisor is '", gcd, "'"), "Dr.Mohammad", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private long GCD1(long n, long m)
        {
            long t = n;
            if (n > m)
                t = m;
            for (long i = t; i > 0; i--)
                if (m % i == 0 && n % i == 0)
                    return i;
            return -1;
        }

        private long GCD2(long n, long m)
        {
            long r;
            if (m < n)
            {
                long tmp = n;
                n = m;
                m = tmp;
            }
            while (n != 0)
            {
                r = m % n;
                m = n;
                n = r;
            }
            return m;
        }

        private long GCD3(long n, long m)
        {
            if (m < n)
            {
                long tmp = n;
                n = m;
                m = tmp;
            }
            long rem = m % n;
            if (rem == 0)
                return n;
            else
                return GCD3(n, rem);
        }
    }
}
