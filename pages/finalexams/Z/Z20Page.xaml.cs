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
    /// Interaction logic for Z20Page.xaml
    /// </summary>
    public partial class Z20Page : Page
    {
        public Z20Page()
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
            string[] hintsArray = { @"\text{Figury w zadaniu są prostokątami podobnymi. Spróbuj znaleźć stosunek długości ich boków.}",
                @"\text{Mniejszy prostokąt, AEFG, ma wymiary 40 x 30, co oznacza, że stosunek długości jego boków wynosi 40:30, po skróceniu 4:3.}",
                @"\text{Prostokąt ABCD i AEFG są podobne, wobec czego stosunek długości jego boków również wynosi 4:3:}
\\ AB = 4x \text{oraz} BC = 3x",
                @"\text{Przekątna prostokąta ABCD ma długość równą 70. Wraz z bokami AB i BC tworzy ona trójkąt prostokątny, } 
\\ \text{którego właściwości umożliwiają wyliczenie długości tych boków. Wystarczy zastosować Twierdzenie Pitagorasa mając na uwadze, że przyprostokątne trójkąta ABC mają długość 3x oraz 4x, a przeciwprostokątna równą 70:}",
                @"(3x)^2+(4x)^2=70^2
\\ 9x^2+16x^2=4900 \\ 25x^2=4900 \\ x^2=196 \\ x=14 \; \bigvee \; x=-14",
                @"\text{Akceptujemy tylko wartość nieujemną, czyli } \; x=14. \\ 
\text{Po jej podstawieniu otrzymasz wartości długości boków prostokąta ABCD:}",
                @"|AB| = 4x = 4 \cdot 14 = 56 \\ |BC| = 3x = 3 \cdot 14 = 42",
                @"\text{Wymiary prostokąta ABCD to 56 x 42 jednostek. Z tą wiedzą możesz obliczyć jego obwód:}
\\ Obw = 2 \cdot 56 + 2 \cdot 42 = 112 + 84 = 196"
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
                if (checkBox1.IsChecked == true || checkBox4.IsChecked == true || checkBox3.IsChecked == true)
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