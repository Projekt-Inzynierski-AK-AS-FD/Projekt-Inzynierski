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
    public partial class Z10Page : Page
    {
        public Z10Page()
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
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Wyznacz miejsca zerowe funkcji. Pomoże w tym rozwiązanie równania:} \; -2(x+3)(x-5)=0",
                @"\text{Równanie to jest równaniem kwadratowym przedstawionym w postaci iloczynowej, w celu jego rozwiązania wystarczy przyrównać wartości w nawiasach do zera:} \\ x+3 = 0 \; \bigvee \; x-5=0",
                @"x=-3 \; \bigvee \; x=5 \\ \text{Miejscami zerowymi funkcji są} \; x=-3 \; \text{oraz} \; x=5.",
                @"\text{Brakuje nam informacji o wartości współrzędnej} \; x \; \text{wierzchołka paraboli, czyli} \; p. \; \text{Oblicz go na podsatwie własności paraboli.}",
                @"\text{Współrzędna} \; p \; \text{wierzchołka paraboli jest średnią arytmetyczną miejsc zerowych funkcji, czyli:} \\ p= \frac{-3+5}{2} = \frac{2}{2} \\ p = 1",
                @"\text{Zatem} \; p \; \text{czyli wspołrzędna} \; x \; \text{wierzchołka paraboli równa jest} 1.",
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
