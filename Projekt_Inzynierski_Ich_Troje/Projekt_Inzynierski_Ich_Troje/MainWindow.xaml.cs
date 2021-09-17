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
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }



        private void DZIALY(object sender, RoutedEventArgs e)
        {
            NavigationService Navserv = new NavigationService();
            Navserv.Navigate(new Uri("WyborDzialu.xaml", UriKind.RelativeOrAbsolute));

            //NavigationService Navserv = new NavigationService();
            //NavigationService.Navigate(new Uri("https://www.google.pl", UriKind.Relative));

            //this.Frame.Navigate(typeof(WyborDzialu));
        }
    }

    //public partial class WyborDzialu
    //{

    //}
}
