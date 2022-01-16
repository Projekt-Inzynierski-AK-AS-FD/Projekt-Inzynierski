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
    /// Interaction logic for Z24Page.xaml
    /// </summary>
    public partial class Z24Page : Page
    {
        public Z24Page()
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
            string[] hintsArray = { @"\text{Oblicz pole powierzchni sześciokąta znajdującego się w dolnej i górnej podstawie bryły. } \\ \text{Jego pole jest równe polu sześciu mniejszych trójkątów równobocznych o boku długości 2:}
\\ P_p = 6 \cdot \frac{a^2 \sqrt{3}}{4} = 6 \cdot \frac{2^2 \sqrt{3}}{4} = 6 \cdot \frac{4 \sqrt{3}}{4}
\\ P_p = 6 \sqrt{3}",
                @"\text{astępnie należy obliczyć pole powierzchni całkowitej, na którą składają się dwie podstawy o polu policzonym powyżej,}
\\ \text{a także 6 kwadratowych ścian o boku równym 2:} \\ P_c = 2P_p + 6P_b = 2 \cdot 6 \sqrt{3} + 6 \cdot 2 \cdot 2
P_c = 12 \sqrt{3} + 24"
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

        private void FormulaControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}