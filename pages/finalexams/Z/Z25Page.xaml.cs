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
    /// Interaction logic for Z25Page.xaml
    /// </summary>
    public partial class Z25Page : Page
    {
        public Z25Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 1; //bo odp. D, czyli checkbox #4
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
            string[] hintsArray = { @"\text{Oblicz długość krawędzi szcześcianu używając wzoru na przekątną sześcianu:}
\\ d = a \sqrt{3}",
                @"\text{Przekątna ma długość 6, a zatem po podstawieniu:} 
\\ a \sqrt{3} = 6 \\ a = \frac{6}{\sqrt{3}} = \frac{6 \cdot \sqrt{3}}{\sqrt{3} \cdot \sqrt{3}} = \frac{6\sqrt{3}}{3}
\\ a = 2\sqrt{3}",
                @"\text{Oblicz objętość szcześcianu używając wzoru:} 
\\ V = a^3",
                @"V = (2 \sqrt{3})^3 = 8 \cdot 3 \sqrt{3}
\\ V = 24\sqrt{3}"
            };
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
                if (checkBox4.IsChecked == true || checkBox2.IsChecked == true || checkBox3.IsChecked == true)
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