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
    public partial class PageW5 : Page
    {
        public PageW5()
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
        private void W1(object sender, RoutedEventArgs e)
        {
            PageW1 pageW1 = new PageW1();
            NavigationService.Navigate(pageW1);
        }
        private void W2(object sender, RoutedEventArgs e)
        {
            PageW2 pageW2 = new PageW2();
            NavigationService.Navigate(pageW2);
        }
        private void W3(object sender, RoutedEventArgs e)
        {
            PageW3 pageW3 = new PageW3();
            NavigationService.Navigate(pageW3);
        }
        private void W4(object sender, RoutedEventArgs e)
        {
            PageW4 pageW4 = new PageW4();
            NavigationService.Navigate(pageW4);
        }
        private void W5(object sender, RoutedEventArgs e)
        {
            PageW5 pageW5 = new PageW5();
            NavigationService.Navigate(pageW5);
        }
        private void W6(object sender, RoutedEventArgs e)
        {
            PageW6 pageW6 = new PageW6();
            NavigationService.Navigate(pageW6);
        }
        private void W7(object sender, RoutedEventArgs e)
        {
            PageW7 pageW7 = new PageW7();
            NavigationService.Navigate(pageW7);
        }
        private void W8(object sender, RoutedEventArgs e)
        {
            PageW8 pageW8 = new PageW8();
            NavigationService.Navigate(pageW8);
        }
        private void W9(object sender, RoutedEventArgs e)
        {
            PageW9 pageW9 = new PageW9();
            NavigationService.Navigate(pageW9);
        }
        private void W10(object sender, RoutedEventArgs e)
        {
            PageW10 pageW10 = new PageW10();
            NavigationService.Navigate(pageW10);
        }
        private void W11(object sender, RoutedEventArgs e)
        {
            PageW11 pageW11 = new PageW11();
            NavigationService.Navigate(pageW11);
        }
        private void W12(object sender, RoutedEventArgs e)
        {
            PageW12 pageW12 = new PageW12();
            NavigationService.Navigate(pageW12);
        }
        private void W13(object sender, RoutedEventArgs e)
        {
            PageW13 pageW13 = new PageW13();
            NavigationService.Navigate(pageW13);
        }
        private void W14(object sender, RoutedEventArgs e)
        {
            PageW14 pageW14 = new PageW14();
            NavigationService.Navigate(pageW14);
        }
        private void W15(object sender, RoutedEventArgs e)
        {
            PageW15 pageW15 = new PageW15();
            NavigationService.Navigate(pageW15);
        }
        private void W16(object sender, RoutedEventArgs e)
        {
            PageW16 pageW16 = new PageW16();
            NavigationService.Navigate(pageW16);
        }
        private void W17(object sender, RoutedEventArgs e)
        {
            PageW17 pageW17 = new PageW17();
            NavigationService.Navigate(pageW17);
        }
        private void W18(object sender, RoutedEventArgs e)
        {
            PageW18 pageW18 = new PageW18();
            NavigationService.Navigate(pageW18);
        }
    }
}
