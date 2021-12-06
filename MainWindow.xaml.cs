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
using System.IO;

namespace Abituria
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCalculator(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow
            {
                Source = new Uri("CalculatorChoice.xaml", UriKind.Relative)
            };
            window.Show();
            this.Visibility = Visibility.Hidden;
        }
        private void ButtonAbituria(object sender, RoutedEventArgs e)
        {
            var mainWin = new MainWindowLogin();
            mainWin.Show();

        }
        private void ButtonMatura(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow
            {
                Source = new Uri("PageMaturaLata.xaml", UriKind.Relative)
            };
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void ButtonDzialy(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow
            {
                Source = new Uri("PageDzialyWybor.xaml", UriKind.Relative)
            };
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void ButtonZadania(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow
            {
                Source = new Uri("PageZadania.xaml", UriKind.Relative)
            };
            window.Show();
            this.Visibility = Visibility.Hidden;
        }
        private void ButtonWzory(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow
            {
                Source = new Uri("PageWzory.xaml", UriKind.Relative)
            };
            window.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}