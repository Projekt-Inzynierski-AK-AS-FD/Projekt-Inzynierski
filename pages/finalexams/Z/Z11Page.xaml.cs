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
    public partial class Z11Page : Page
    {
        public Z11Page()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 4;
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
            string[] hintsArray = { @"\text{Sporządź rysunek pomocniczy i odczytaj z niego zbiór wartości funkcji.}",
                @"\text{Wykresem będzie parabola. Należy przekształcić  wykres funkcji kawadratowej} \\ f(x)=x^2 \; \text{poprzez odwrócenie paraboli wobec osi } \; OX, \; \text{o czym informuje minus przed } \; x^2.
                \\ \text{Parabolę trzeba narysować o 4 jednostki wyżej, o czym informuje +4 zawarte we wzorze.}",
                @"\text{Wartości funkcji należy odczytać z osi } \; OY. \; \text{Funkcja przyjmuje wartości od} \;-\infty \; \text{do 4, więc zbiorem jej wartości jest przedział} \;  (- \infty , 4>."
            };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = "";
            this.hintFormula.Formula = hint;
        }
        private bool CheckAnswer(int correctAnsw)
        {
            bool isAnsCorrect;
            if (checkBox4.IsChecked == true)
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