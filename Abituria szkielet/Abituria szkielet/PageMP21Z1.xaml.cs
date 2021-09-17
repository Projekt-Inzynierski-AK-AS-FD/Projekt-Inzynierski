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

namespace Abituria
{
    /// <summary>
    /// Logika interakcji dla klasy PageMatura.xaml
    /// </summary>
    public partial class PageMP21Z1 : Page
    {
        public PageMP21Z1()
        {
            InitializeComponent();
        }

        private void ButtonAbituria(object sender, RoutedEventArgs e)
        {
            var mainWin = new MainWindow();
            mainWin.Show();

        }

        private void ButtonKalkulator(object sender, RoutedEventArgs e)
        {
            var calculator = new Calculator();
            calculator.Show();
        }

        private void ButtonMatura(object sender, RoutedEventArgs e)
        {

            //MaturaFrame.NavigationService.Navigate(new Uri("PageMatura.xaml", UriKind.Relative));
            //MaturaFrame.NavigationService.Navigate(new PageMatura());
            //MaturaFrame.Content = new PageMatura();

            PageMaturaLata pageMaturaLata = new PageMaturaLata();
            NavigationService.Navigate(pageMaturaLata);
        }

        private void ButtonDzialy(object sender, RoutedEventArgs e)
        {
            //przełączenie z jednej strony (matury) na inną
            PageDzialy pageDzialy = new PageDzialy();
            NavigationService.Navigate(pageDzialy);


        }

        private void ButtonZadania(object sender, RoutedEventArgs e)
        {
            PageZadania pageZadania = new PageZadania();
            NavigationService.Navigate(pageZadania);
        }

        private void ButtonWideo(object sender, RoutedEventArgs e)
        {
            PageWideo pageWideo = new PageWideo();
            NavigationService.Navigate(pageWideo);
        }
        private void Button2021(object sender, RoutedEventArgs e)
        {
            PageMaturaPoprawkowa2021 pageMaturaPoprawkowa2021 = new PageMaturaPoprawkowa2021();
            NavigationService.Navigate(pageMaturaPoprawkowa2021);
        }
        private void Button2020(object sender, RoutedEventArgs e)
        {
            PageMatura2020 pageMatura2020 = new PageMatura2020();
            NavigationService.Navigate(pageMatura2020);
        }
        private void Button2019(object sender, RoutedEventArgs e)
        {
            PageMatura2019 pageMatura2019 = new PageMatura2019();
            NavigationService.Navigate(pageMatura2019);
        }
    }
}
