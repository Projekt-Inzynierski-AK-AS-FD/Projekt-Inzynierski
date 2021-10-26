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
using System.Windows.Shapes;

namespace Abituria
{
    /// <summary>
    /// Interaction logic for CalcQuadraticFunc.xaml
    /// </summary>
    public partial class CalcQuadraticFunc : Window
    {
        public CalcQuadraticFunc()
        {
            InitializeComponent();
        }

        private void Przelicz(object sender, RoutedEventArgs e)
        {
            if (this.pOgolna.Visibility == Visibility.Visible)
            {
                float warA = float.Parse(fieldA.Text);
                FunKwadratOgolna(warA, 20, 10);
            }
            else 
            {
                MessageBox.Show("wiadomość testowa Ten warunek nie działa byku");
            }
            
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sashku mlemaj gdzie indziej");
        }

        private void ButtonOgolna(object sender, RoutedEventArgs e)
        {
            if (this.pOgolna.Visibility == Visibility.Collapsed && this.buttonPrzelicz.Visibility == Visibility.Collapsed && this.buttonReset.Visibility == Visibility.Collapsed)
            {
                this.pOgolna.Visibility = Visibility.Visible;
                this.buttonPrzelicz.Visibility = Visibility.Visible;
                this.buttonReset.Visibility = Visibility.Visible;
            }
            else
            {
                this.pOgolna.Visibility = Visibility.Collapsed;
                this.buttonPrzelicz.Visibility = Visibility.Collapsed;
                this.buttonReset.Visibility = Visibility.Collapsed;
            }
        }

        private void ButtonIloczynowa(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }
        private void ButtonKanoniczna(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }

        private void FunKwadratOgolna(float a, float b, float c)
        {
            
            float result = a + b + c;
            
            MessageBox.Show("haha  " + result);
        }

    }
}

