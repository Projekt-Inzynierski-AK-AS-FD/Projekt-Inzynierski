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
    public partial class Z17Page : Page
    {
        public Z17Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
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
            string[] hintsArray = { @"\text{Przeanalizuj odpowiedzi lub podstaw do każdej z nich} \; x=-2, \text{aby sprawdzić kiedy obie strony równania będą sobie równe.}",
                @"\text{Odp. A: 4 zostaje przeniesiona na drugą stronę, co daje równanie } \; x^2 = -4. \; \\ \text{Takie równanie nie posiada rozwiązań, ponieważ nie znajdziemy takiej liczby rzeczywistej, która po podniesieniu do kwadratu dałaby ujemny wynik.}",
                @"\text{Odp. B: Po pomnożeniu stron równania przez 2 otrzymujemy równanie} \; x+2=2, \; \text{co daje} \; x=0.",
                @"\text{Odp. C: Wartość w mianowniku musi być różna od 0! Liczba -2 nie jest zatem rozwiązaniem, ponieważ } \\ x+2 \neq 0, \text{więc} \; x \neq -2.",
                @"\text{Odp D:} \; x^2(x+2)+2(x+2)=0",
                @"(x^2+2)(x+)=0 \; \; x^2+2=0 \; \bigvee \; x+2=0 \\ x^2=-2 \; \bigvee \; x=-2",
                @"\text{Równanie} \;  x^2=-2 \; \text{nie da rozwiązań. Odpowiedź D jest jednak poprawna, ponieważ równanie} \; x+2=0 \; \text{zwraca także} \; x=-2, \; \text{czyli odpowiedź.}"
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