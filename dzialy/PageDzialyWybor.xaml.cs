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
using Abituria.matury;
using Abituria.wzory;
using Abituria.zadania;
namespace Abituria.dzialy
{
    public partial class PageDzialyWybor : Page
    {
        public PageDzialyWybor()
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
        private void ButtonDzial1(object sender, RoutedEventArgs e)
        {
            PageDzial1 pageDzial1 = new PageDzial1();
            NavigationService.Navigate(pageDzial1);
        }
        private void ButtonDzial2(object sender, RoutedEventArgs e)
        {
            PageDzial2 pageDzial2 = new PageDzial2();
            NavigationService.Navigate(pageDzial2);
        }
        private void ButtonDzial3(object sender, RoutedEventArgs e)
        {
            PageDzial3 pageDzial3 = new PageDzial3();
            NavigationService.Navigate(pageDzial3);
        }
    }
}
