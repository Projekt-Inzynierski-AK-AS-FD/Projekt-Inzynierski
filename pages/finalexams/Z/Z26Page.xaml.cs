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
    /// Interaction logic for Z26Page.xaml
    /// </summary>
    public partial class Z26Page : Page
    {
        public Z26Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 2; //bo odp. D, czyli checkbox #4
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            string answer = HintsClass.AnswerButtonChange(sender, CheckAnswer(correctAnsw: correctAnsw));
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = answer;
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Przypomnij sobie reguły mnożenia i na tej podstawie przeanalizuj możliwości uzupełnienia cyfr.}",
            @"\text{Pierwsza cyfra - żadna liczba nie może zaczynać się od zera, dlatego dostępne są cyfry od 1 do 9,}
\\ \text{ wobec czego rozważane jest 9 możliwości,}",
            @"\text{Druga, trzecia i czwarta cyfra - dla każdego z tych miejsc dostępna jest każda cyfra od 0 do 9,}
\\ \text{ wobec czego rozważane jest 9 możliwości,}",
            @"\text{Piąta cyfra - liczba będzie parzysta, gdy będzie kończyła się cyfrą parzystą,}
\\ \text{ więc dla piątego miejsca dostępne są cyfry 2, 4, 6, 8 oraz 0, co daje łącznie 5 możliwości.}",
            @"\text{Reguła mnożenia mówi, że wszystkich liczb pięciocyfrowych parzystych jest:}
\\ 9 \cdot 10 \cdot 10 \cdot 10 \cdot 5",
            @"10 \cdot 10 \cdot 10 = 10^3, więc odpowiedzią jest 9 \cdot 5 \cdot 10^3"
            };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = "";
            this.hintFormula.Formula = hint;
        }
        private bool CheckAnswer(int correctAnsw)
        {
            bool isAnsCorrect;
            if (checkBox2.IsChecked == true)
            {
                if (checkBox1.IsChecked == true || checkBox2.IsChecked == true || checkBox3.IsChecked == true)
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