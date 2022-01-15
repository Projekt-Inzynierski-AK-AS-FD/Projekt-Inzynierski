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
    public partial class Z23Page : Page
    {
        public Z23Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 3; //bo odp. D, czyli checkbox #4
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
            string[] hintsArray = {
            @"\text{Korzystając ze wzoru na długość odcinka i danych o współrzędnych punktów A i C, oblicz długość odcinka AC będącego przekątną kwadratu ABCD:}",
            @"|AC| = \sqrt{(x_C-x_A)^2+(y_C-y_A)^2}",
            @"|AC| = \sqrt{(-4-3)^2+(6-7)^2} = \sqrt{(-7)^2+(-1)^2} = \sqrt{49+1} = \sqrt{50} = \sqrt{25 \cdot 2}",
            @"|AC| = 5\sqrt{2}",
            @"\text{Oblicz długość promienia okręgu pamietając, że promień okręgu opisanego na kwadracie jest równy długości połowy przekątnej,} \\  \text{której długość przed chwilą obliczono, więc:}
\\ r=\frac{5\sqrt{2}}{2}"
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