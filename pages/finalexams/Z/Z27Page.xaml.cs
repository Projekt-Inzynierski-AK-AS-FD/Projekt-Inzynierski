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

namespace Abituria.pages
{
    /// <summary>
    /// Interaction logic for Z27Page.xaml
    /// </summary>
    public partial class Z27Page : Page
    {
        public Z27Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 3; //bo odp. D, czyli checkbox #4
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            string answer = HintsClass.AnswerButtonChange(sender, CheckAnswer(correctAnsw: correctAnsw));
            brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = answer;
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Stosunek ku białych do czerwonych (3:4) można zapisać jako:}
\\ 3x - \text{liczba kul białych} \\ 4x - \text{liczba kul czerwonych}
\\ 3x + 4x = 7x -  \text{liczba kul łącznie}
\\ A - \; \text{- wydarzenie wylosowania kuli białej}",
                @"\text{Prawdopodobieństwo oblicza się ze wzoru:}
\\ P(A) = \frac{|A|}{| \Omega |} \; \text{gdzie} \\
|A| - \text{to liczba zdarzeń sprzyjających} \\
| \Omega | - \text{to liczba wszystkich możliwych zdarzeń}",
                @"P(A) = \frac{3x}{7x} = \frac{3}{7}"
            };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = "";
            this.hintFormula.Formula = hint;
        }
        private bool CheckAnswer(int correctAnsw)
        {
            bool isAnsCorrect;
            if (checkBox3.IsChecked == true)
            {
                if (checkBox1.IsChecked == true || checkBox2.IsChecked == true || checkBox4.IsChecked == true)
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