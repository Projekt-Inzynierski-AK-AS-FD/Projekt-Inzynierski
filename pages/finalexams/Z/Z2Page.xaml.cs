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
    public partial class Z2Page : Page
    {
        public Z2Page()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 3; //bo odp. C, czyli checkbox #3
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
            string[] hintsArray = { @"\text{Spróbuj wykorzystać własności logarytmów.}", @"\text{Składnik} \; 2log_62 \; \text{można zapisać jako} \; log_62^2.", @"log_69 + 2log_62 = log_69+log_62^2=log_69+log_64", @"\text{Logarytmy mają teraz taką samą podstawę. Możesz skorzystać ze wzoru na sumę logarytmów:} \\ log_69+log_64=log_6(9 \cdot 4)=log_636=2" };
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