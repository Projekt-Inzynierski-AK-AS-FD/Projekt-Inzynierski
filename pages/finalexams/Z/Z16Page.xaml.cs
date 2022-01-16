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
    public partial class Z16Page : Page
    {
        public Z16Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 2;
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
            string[] hintsArray = { @"\text{Skorzystaj z jedynki trygonometrycznej:} \\sin^2 \alpha + cos^2 \alpha = 1",
                @"( \frac{7}{25})^2 +cos^2 \alpha = 1 \\ \frac{49}{625} +cos^2 \alpha = 1",
                @"cos^2 \alpha = \frac{576}{625} \\ cos \alpha = \frac{24}{25} \; \bigvee \; cos \alpha = -\frac{24}{25}",
                @"\text{Kąt} \; \alpha \; \text{jest ostry, przez co należy odrzucić ujemną wartość.}",
                @"\text{Prawidłową odpowiedzią jest } \; cos \alpha = \frac{24}{25}"
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