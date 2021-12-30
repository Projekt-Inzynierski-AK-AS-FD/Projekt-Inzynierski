using Abituria.dzialy;
using Abituria.matury;
using Abituria.zadania;
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
using Abituria.matury;
using Abituria.wzory;
namespace Abituria.wzory
{
    public partial class PageW10 : Page
    {
        public PageW10()
        {
            InitializeComponent();
            List<string> chaptersList = new List<string>()
            {
                "Wartość Bezwzględna", "Potęgi i pierwiastki", "Logarytmy", "Silnia. Współczynnik dwumianowy", "Dwumian Newtona", "Wzory skróconego mnożenia", "Ciągi", "Funkcja kwadratowa", "Geometria", "Planimetria", "Stereometria", "Trygonometria", "Kombinatoryka", "Prawdopodobieństwo", "Statystyka", "Granice", "Pochodne", "Tablica wartości funkcji trygonometrycznych"
            };
            cbChapters.ItemsSource = chaptersList;
        }
        void ChangePage(object sender, SelectionChangedEventArgs args)
        {
            string selectedItem = cbChapters.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Wartość Bezwzględna":
                    PageW1 pageW1 = new PageW1();
                    NavigationService.Navigate(pageW1);
                    cbChapters.Text = selectedItem;
                    cbChapters.SelectedIndex = 0;
                    break;
                case "Potęgi i pierwiastki":
                    PageW2 pageW2 = new PageW2();
                    NavigationService.Navigate(pageW2);
                    cbChapters.Text = selectedItem;
                    break;
                case "Logarytmy":
                    PageW3 pageW3 = new PageW3();
                    NavigationService.Navigate(pageW3);
                    cbChapters.Text = selectedItem;
                    break;
                case "Silnia. Współczynnik dwumianowy":
                    PageW4 pageW4 = new PageW4();
                    NavigationService.Navigate(pageW4);
                    cbChapters.Text = selectedItem;
                    break;
                case "Dwumian Newtona":
                    PageW5 pageW5 = new PageW5();
                    NavigationService.Navigate(pageW5);
                    cbChapters.Text = selectedItem;
                    break;
                case "Wzory skróconego mnożenia":
                    PageW6 pageW6 = new PageW6();
                    NavigationService.Navigate(pageW6);
                    cbChapters.Text = selectedItem;
                    break;
                case "Ciągi":
                    PageW7 pageW7 = new PageW7();
                    NavigationService.Navigate(pageW7);
                    cbChapters.Text = selectedItem;
                    break;
                case "Funkcja kwadratowa":
                    PageW8 pageW8 = new PageW8();
                    NavigationService.Navigate(pageW8);
                    cbChapters.Text = selectedItem;
                    break;
                case "Geometria":
                    PageW9 pageW9 = new PageW9();
                    NavigationService.Navigate(pageW9);
                    cbChapters.Text = selectedItem;
                    break;
                case "Planimetria":
                    PageW10 pageW10 = new PageW10();
                    NavigationService.Navigate(pageW10);
                    cbChapters.Text = selectedItem;
                    break;
                case "Stereometria":
                    PageW11 pageW11 = new PageW11();
                    NavigationService.Navigate(pageW11);
                    cbChapters.Text = selectedItem;
                    break;
                case "Trygonometria":
                    PageW12 pageW12 = new PageW12();
                    NavigationService.Navigate(pageW12);
                    cbChapters.Text = selectedItem;
                    break;
                case "Kombinatoryka":
                    PageW13 pageW13 = new PageW13();
                    NavigationService.Navigate(pageW13);
                    cbChapters.Text = selectedItem;
                    break;
                case "Prawdopodobieństwo":
                    PageW14 pageW14 = new PageW14();
                    NavigationService.Navigate(pageW14);
                    cbChapters.Text = selectedItem;
                    break;
                case "Statystyka":
                    PageW15 pageW15 = new PageW15();
                    NavigationService.Navigate(pageW15);
                    cbChapters.Text = selectedItem;
                    break;
                case "Granice":
                    PageW16 pageW16 = new PageW16();
                    NavigationService.Navigate(pageW16);
                    cbChapters.Text = selectedItem;
                    break;
                case "Pochodne":
                    PageW17 pageW17 = new PageW17();
                    NavigationService.Navigate(pageW17);
                    cbChapters.Text = selectedItem;
                    break;
                case "Tablica wartości funkcji trygonometrycznych":
                    PageW18 pageW18 = new PageW18();
                    NavigationService.Navigate(pageW18);
                    cbChapters.Text = selectedItem;
                    break;
                default:
                    PageWzory pageWzory = new PageWzory();
                    NavigationService.Navigate(pageWzory);
                    break;
            }
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
