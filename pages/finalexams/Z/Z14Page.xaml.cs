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
    public partial class Z14Page : Page
    {
        public Z14Page()
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
            string[] hintsArray = { @"\text{Zastanów się, jaka jest relacja między liczbami parzystymi mniejszymi od } \; 1001: \\ 2,4,6,8,10,...,996,996,1000",
                @"\text{Jest to ciąg arytmetyczny o następujących właściwościach:} \\ a_1 = 2, \; a_n=1000, \; r=2 \\ \text{Ustal, ile jest takich wyrazów, czyli } \; n.",
                @"n=500",
                @"\text{Następnie należy zapisać sumę wyrazów korzystając ze wzoru na sumę} \; n-\text{początkowych wyrazów ciągu arytmetycznego:} \\ S_n= \frac{a_1 + a_n)}{2} \cdot n",
                @"\text{Podstaw odpowiednie wartości:} \; S_{500}= \frac{2+1000}{2} \cdot 500"
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