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
using Abituria.wzory;
using Abituria.zadania;
namespace Abituria.matury.mp21
{
    public partial class PageMP21Z10 : Page
    {
        public PageMP21Z10()
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
        private void MP2021Zad1(object sender, RoutedEventArgs e)
        {
            PageMP21Z1 pageMP21Z1 = new PageMP21Z1();
            NavigationService.Navigate(pageMP21Z1);
        }
        private void MP2021Zad2(object sender, RoutedEventArgs e)
        {
            PageMP21Z2 pageMP21Z2 = new PageMP21Z2();
            NavigationService.Navigate(pageMP21Z2);
        }
        private void MP2021Zad3(object sender, RoutedEventArgs e)
        {
            PageMP21Z3 pageMP21Z3 = new PageMP21Z3();
            NavigationService.Navigate(pageMP21Z3);
        }
        private void MP2021Zad4(object sender, RoutedEventArgs e)
        {
            PageMP21Z4 pageMP21Z4 = new PageMP21Z4();
            NavigationService.Navigate(pageMP21Z4);
        }
        private void MP2021Zad5(object sender, RoutedEventArgs e)
        {
            PageMP21Z5 pageMP21Z5 = new PageMP21Z5();
            NavigationService.Navigate(pageMP21Z5);
        }
        private void MP2021Zad6(object sender, RoutedEventArgs e)
        {
            PageMP21Z6 pageMP21Z6 = new PageMP21Z6();
            NavigationService.Navigate(pageMP21Z6);
        }
        private void MP2021Zad7(object sender, RoutedEventArgs e)
        {
            PageMP21Z7 pageMP21Z7 = new PageMP21Z7();
            NavigationService.Navigate(pageMP21Z7);
        }
        private void MP2021Zad8(object sender, RoutedEventArgs e)
        {
            PageMP21Z8 pageMP21Z8 = new PageMP21Z8();
            NavigationService.Navigate(pageMP21Z8);
        }
        private void MP2021Zad9(object sender, RoutedEventArgs e)
        {
            PageMP21Z9 pageMP21Z9 = new PageMP21Z9();
            NavigationService.Navigate(pageMP21Z9);
        }
        private void MP2021Zad10(object sender, RoutedEventArgs e)
        {
            PageMP21Z10 pageMP21Z10 = new PageMP21Z10();
            NavigationService.Navigate(pageMP21Z10);
        }
        private void MP2021Zad11(object sender, RoutedEventArgs e)
        {
            PageMP21Z11 pageMP21Z11 = new PageMP21Z11();
            NavigationService.Navigate(pageMP21Z11);
        }
        private void MP2021Zad12(object sender, RoutedEventArgs e)
        {
            PageMP21Z12 pageMP21Z12 = new PageMP21Z12();
            NavigationService.Navigate(pageMP21Z12);
        }
        private void MP2021Zad13(object sender, RoutedEventArgs e)
        {
            PageMP21Z13 pageMP21Z13 = new PageMP21Z13();
            NavigationService.Navigate(pageMP21Z13);
        }
        private void MP2021Zad14(object sender, RoutedEventArgs e)
        {
            PageMP21Z14 pageMP21Z14 = new PageMP21Z14();
            NavigationService.Navigate(pageMP21Z14);
        }
        private void MP2021Zad15(object sender, RoutedEventArgs e)
        {
            PageMP21Z15 pageMP21Z15 = new PageMP21Z15();
            NavigationService.Navigate(pageMP21Z15);
        }
        private void MP2021Zad16(object sender, RoutedEventArgs e)
        {
            PageMP21Z16 pageMP21Z16 = new PageMP21Z16();
            NavigationService.Navigate(pageMP21Z16);
        }
        private void MP2021Zad17(object sender, RoutedEventArgs e)
        {
            PageMP21Z17 pageMP21Z17 = new PageMP21Z17();
            NavigationService.Navigate(pageMP21Z17);
        }
        private void MP2021Zad18(object sender, RoutedEventArgs e)
        {
            PageMP21Z18 pageMP21Z18 = new PageMP21Z18();
            NavigationService.Navigate(pageMP21Z18);
        }
        private void MP2021Zad19(object sender, RoutedEventArgs e)
        {
            PageMP21Z19 pageMP21Z19 = new PageMP21Z19();
            NavigationService.Navigate(pageMP21Z19);
        }
        private void MP2021Zad20(object sender, RoutedEventArgs e)
        {
            PageMP21Z20 pageMP21Z20 = new PageMP21Z20();
            NavigationService.Navigate(pageMP21Z20);
        }
        private void MP2021Zad21(object sender, RoutedEventArgs e)
        {
            PageMP21Z21 pageMP21Z21 = new PageMP21Z21();
            NavigationService.Navigate(pageMP21Z21);
        }
        private void MP2021Zad22(object sender, RoutedEventArgs e)
        {
            PageMP21Z22 pageMP21Z22 = new PageMP21Z22();
            NavigationService.Navigate(pageMP21Z22);
        }
        private void MP2021Zad23(object sender, RoutedEventArgs e)
        {
            PageMP21Z23 pageMP21Z23 = new PageMP21Z23();
            NavigationService.Navigate(pageMP21Z23);
        }
        private void MP2021Zad24(object sender, RoutedEventArgs e)
        {
            PageMP21Z24 pageMP21Z24 = new PageMP21Z24();
            NavigationService.Navigate(pageMP21Z24);
        }
        private void MP2021Zad25(object sender, RoutedEventArgs e)
        {
            PageMP21Z25 pageMP21Z25 = new PageMP21Z25();
            NavigationService.Navigate(pageMP21Z25);
        }
        private void MP2021Zad26(object sender, RoutedEventArgs e)
        {
            PageMP21Z26 pageMP21Z26 = new PageMP21Z26();
            NavigationService.Navigate(pageMP21Z26);
        }
        private void MP2021Zad27(object sender, RoutedEventArgs e)
        {
            PageMP21Z27 pageMP21Z27 = new PageMP21Z27();
            NavigationService.Navigate(pageMP21Z27);
        }
        private void MP2021Zad28(object sender, RoutedEventArgs e)
        {
            PageMP21Z28 pageMP21Z28 = new PageMP21Z28();
            NavigationService.Navigate(pageMP21Z28);
        }
        private void MP2021Zad29(object sender, RoutedEventArgs e)
        {
            PageMP21Z29 pageMP21Z29 = new PageMP21Z29();
            NavigationService.Navigate(pageMP21Z29);
        }
        private void MP2021Zad30(object sender, RoutedEventArgs e)
        {
            PageMP21Z30 pageMP21Z30 = new PageMP21Z30();
            NavigationService.Navigate(pageMP21Z30);
        }
        private void MP2021Zad31(object sender, RoutedEventArgs e)
        {
            PageMP21Z31 pageMP21Z31 = new PageMP21Z31();
            NavigationService.Navigate(pageMP21Z31);
        }
        private void MP2021Zad32(object sender, RoutedEventArgs e)
        {
            PageMP21Z32 pageMP21Z32 = new PageMP21Z32();
            NavigationService.Navigate(pageMP21Z32);
        }
        private void MP2021Zad33(object sender, RoutedEventArgs e)
        {
            PageMP21Z33 pageMP21Z33 = new PageMP21Z33();
            NavigationService.Navigate(pageMP21Z33);
        }
        private void MP2021Zad34(object sender, RoutedEventArgs e)
        {
            PageMP21Z34 pageMP21Z34 = new PageMP21Z34();
            NavigationService.Navigate(pageMP21Z34);
        }
        private void MP2021Zad35(object sender, RoutedEventArgs e)
        {
            PageMP21Z35 pageMP21Z35 = new PageMP21Z35();
            NavigationService.Navigate(pageMP21Z35);
        }
    }
}
