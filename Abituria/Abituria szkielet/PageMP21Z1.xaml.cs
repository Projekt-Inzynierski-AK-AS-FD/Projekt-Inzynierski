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
        int clickCounter = 0;
        int correctAnsw = 4; //bo odp. D, czyli checkbox #4
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

        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            bool ansChecked = CheckAnswer(correctAnsw);
            string answer = HintsClass.AnswerButtonChange(sender, ansChecked);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = answer;
        }

        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            string hint = HintsClass.HintMP21Z1(clickCounter);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = hint;
        }
        private bool CheckAnswer(int correct)
        {
            bool isAnsCorrect = false;
            if(checkBox4.IsChecked == true)
            {
                if(checkBox1.IsChecked == true || checkBox2.IsChecked == true || checkBox3.IsChecked == true)
                {
                    isAnsCorrect = false;
                }
                else
                {
                    isAnsCorrect = true;
                }
            }
            else
            {
                isAnsCorrect = false;
            }

            return isAnsCorrect;
        }
    }
}
