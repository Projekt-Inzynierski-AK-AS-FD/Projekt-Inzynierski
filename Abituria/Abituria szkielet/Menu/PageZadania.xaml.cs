﻿using System;
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
    /// Logika interakcji dla klasy PageZadania.xaml
    /// </summary>
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
            PageDzialyWybor pageDzialyWybor = new PageDzialyWybor();
            NavigationService.Navigate(pageDzialyWybor);
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
    }
}