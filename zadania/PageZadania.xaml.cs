using Abituria.dzialy;
using Abituria.matury;
using Abituria.wzory;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
namespace Abituria.zadania
{
    public partial class PageZadania : Page
    {
        public PageZadania()
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
    }
}
