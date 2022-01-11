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
    /// Interaction logic for Z6Page.xaml
    /// </summary>
    public partial class Z6Page : Page
    {
        public Z6Page()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 3;
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
            string[] hintsArray = { @"\text{Rozwiąż równanie. Zacznij od pomnożenia obydwu jego stron przez} \; 4:",
                @"5- \frac{2-6x}{4} \geq 2x+1  \cdot 4 \\ 20 - (2-6x) \geq 8x+4",
                @"20-2+6x \geq 8x+4 \\ 18+6x \geq 8x + 4",
                @"-2x \geq -14 /:(-2)",
                @"\text{Obydwie strony nierówności są dzielone przez liczbę ujemną, dlatego pamiętaj o zmianie znaku na przeciwny.}",
                @"x \leq 7",
                @"\text{Rozwiązaniem są wszystkie liczby, które są równe lub mniejsze od 7, więc odpowiedzią jest przedział} \; (- \infty , 7>."
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
