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

namespace Projekt_Inzynierski
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class WyborDzialu : Window
    {
        public WyborDzialu()
        {
            InitializeComponent();

        }

        private void PrzyciskDzialI(object sender, RoutedEventArgs e)
        {
            tekstPow.Visibility = Visibility.Hidden;

            if (this.TestTekst.Visibility == Visibility.Collapsed)
            {
                this.TestTekst.Visibility = Visibility.Visible;
                this.Lista.Visibility = Visibility.Visible;
            }
            else
            {
                this.TestTekst.Visibility = Visibility.Collapsed;
                this.Lista.Visibility = Visibility.Collapsed;
            }


        }


        private void PrzyciskDzialII(object sender, RoutedEventArgs e)
        {

        }

        private void PrzyciskDzialIII(object sender, RoutedEventArgs e)
        {

        }

        private void PrzyciskDzialIV(object sender, RoutedEventArgs e)
        {

        }

        private void PrzyciskDzialV(object sender, RoutedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
