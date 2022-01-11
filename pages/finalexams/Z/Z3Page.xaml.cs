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
    public partial class Z3Page : Page
    {
        public Z3Page()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 1;
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
            string[] hintsArray = { @"\text{Jeżeli} \: x \: \text{stanowi} \: 80\% \: \text{liczby, którą jest} \: y, \: \text{o} \: x \: \text{możemy powiedzieć:} \\ x = 0,8 y",
                @"\text{Zgodnie z postępowaniem z działaniami na niewiadomych, podziel obydwie strony przez} \; 0,8. \; \text{Zamiast tego, możesz je też pomnożyć przez odwrotność tej liczby, czyli} \; \frac{10}{8}:",
                @"x \cdot \frac{10}{8} = 0,8y \cdot \frac{10}{8}",
                @"1,25x = y \: \: -> \: \:  y = 1,25x \\ 1,25 \cdot 100\% = 125\%, \text{czyli liczba} \; y \; \text{stanowi} \; 125\% \; \text{liczby} \; x." };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = "";
            this.hintFormula.Formula = hint;
        }
        private bool CheckAnswer(int correctAnsw)
        {
            bool isAnsCorrect;
            if (checkBox1.IsChecked == true)
            {
                if (checkBox3.IsChecked == true || checkBox2.IsChecked == true || checkBox4.IsChecked == true)
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
