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
    /// Interaction logic for Z7Page.xaml
    /// </summary>
    public partial class Z7Page : Page
    {
        public Z7Page()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
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
            string[] hintsArray = { @"\text{Wykres funkcji} \; f \; \text{przesunięto o 2 jednostki w lewo, dzięki czemu powstała nowa funkcja,} \; g(x), \\ \text{której wzór nieco się różni. Aby go uzyskać, do wzoru funkcji} \; f(x) \; \text{w miejsce} \; x \; \text{należy podstawić} \; x+2.",
                @"g(x) = -2 \cdot (x+2) +4",
                @"g(x) = -2x - 4 +4",
                @"g(x) = -2x"
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