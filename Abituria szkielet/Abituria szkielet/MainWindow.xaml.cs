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

namespace Abituria_szkielet
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Kod na wyświetlenie osobnego okna z kalkulatorem po kliknięciu buttona
            var calculator = new Calculator();
            calculator.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MainFrame.NavigationService.Navigate(new Uri("PageMatura.xaml", UriKind.Relative));
            //MainFrame.NavigationService.Navigate(new PageMatura());
            // MainFrame.Content = new PageMatura();

            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("PageMatura.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;

            //Ta linijka będzie przydatna, gdy zamiast main window będzie uruchamiało się main page, bo w tej formie ukrywa całe okno
            //Application.Current.MainWindow.Visibility = Visibility.Hidden;

        }
    }
}
