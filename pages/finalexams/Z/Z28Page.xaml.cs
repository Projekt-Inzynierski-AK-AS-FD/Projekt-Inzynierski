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
    /// Interaction logic for Z28Page.xaml
    /// </summary>
    public partial class Z28Page : Page
    {
        public Z28Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 2; //bo odp. D, czyli checkbox #4
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
            string[] hintsArray = { @"9^{-10} \cdot 3^{19} = (3^2)^{-10} \cdot 3^{19}", @"(3^2)^{-10} \cdot 3^{19} = 3^{-20} \cdot 3^{19}", @"3^{-20} \cdot 3^{19} = 3^{-20+19}", @"= 3^{-1}" };
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