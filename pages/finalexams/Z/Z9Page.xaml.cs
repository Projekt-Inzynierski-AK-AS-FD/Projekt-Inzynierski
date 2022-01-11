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
    /// Interaction logic for Z9Page.xaml
    /// </summary>
    public partial class Z9Page : Page
    {
        public Z9Page()
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
            string[] hintsArray = { @"\text{Wiadomym jest, że wykres funkcji jest rosnący, co znaczy, iż współczynnik } \; a \; \text{musi być dodatni.}",
                @"\text{Po przeanalizowaniu odpowiedzi można odrzucić odp. B i C, ponieważ dodatni współczynnik a znajduje się tylko w odp. A i D.}",
                @"\text{Współczynnik} \; b, \; \text{będzie ujemny - wykres funkcji przecina oś } \; OY \; \text{dla ujemnych wartości} \; y. \\ \text{Odp. D jest zatem niepoprawna.}",
                @"\text{Po eliminacji pozostaje odp. A,} \; y=x-5."
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
    }
}
