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

        private void ButtonPrzelicz(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sasha śpi w moim łożku i nie mogę się położyć spać");
        }

        private void ButtonReset(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sashku mlemaj gdzie indziej");
        }

        private void ButtonOgolna(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }

        private void ButtonIloczynowa(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }
        private void ButtonKanoniczna(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }
    }
}

