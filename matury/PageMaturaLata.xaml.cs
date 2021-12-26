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
using Abituria.dzialy;
using Abituria.matury;
using Abituria.wzory;
using Abituria.zadania;
namespace Abituria.matury
{
    public partial class PageMaturaLata : Page
    {
        public PageMaturaLata()
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
            var calculator = new CalculatorChoice();
            NavigationService.Navigate(calculator);
        }
        private void ButtonMatura(object sender, RoutedEventArgs e)
        {
            PageMaturaLata pageMaturaLata = new PageMaturaLata();
            NavigationService.Navigate(pageMaturaLata);
        }
        private void ButtonDzialy(object sender, RoutedEventArgs e)
        {
            //przełączenie z jednej strony (matury) na inną
            PageDzialyWybor pageDzialyWybor = new PageDzialyWybor();
            NavigationService.Navigate(pageDzialyWybor);
        }
        private void ButtonZadania(object sender, RoutedEventArgs e)
        {
            PageZadania pageZadania = new PageZadania();
            NavigationService.Navigate(pageZadania);
        }
        private void ButtonWzory(object sender, RoutedEventArgs e)
        {
            PageWzory pageWzory = new PageWzory();
            NavigationService.Navigate(pageWzory);
        }
        private void Button2021(object sender, RoutedEventArgs e)
        {
            PageMatura2021 pageMatura2021 = new PageMatura2021();
            NavigationService.Navigate(pageMatura2021);
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
        private void Button2021Poprawkowy(object sender, RoutedEventArgs e)
        {
            PageMaturaPoprawkowa2021 pageMaturaPoprawkowa2021 = new PageMaturaPoprawkowa2021();
            NavigationService.Navigate(pageMaturaPoprawkowa2021);
        }
    }
}
