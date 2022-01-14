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
    public partial class Z15Page : Page
    {
        public Z15Page()
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
            string[] hintsArray = { @"\text{Wyliczenie wartości } \; x \; \text{będzie łatwe, gdy przypomnisz sobie własności ciągów geometrycznych.}
\\ \text{Wynika z nich, iż dla trzech kolejnych wyrazów ciągu geometrycznego zachodzi:} \\ a_2^2=a_1 \cdot a_3",
                @"\text{Podstaw dane:} \\ x^2 = 2 \cdot 18 \\ x^2 = 36 \\ x=6 \; \bigvee \; x=-6",
                @"\text{Otrzymano dwie wartości, ale tylko jedna jest poprawna. Dla } \; x=-6 \\ \text{ciąg będzie niemonotoniczny, a nie rosnący. Właściwe rozwiązanie to} \; x=6."
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