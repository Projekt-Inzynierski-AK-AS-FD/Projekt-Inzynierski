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
    /// Interaction logic for Z30Page.xaml
    /// </summary>
    public partial class Z30Page : Page
    {
        public Z30Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 4; //bo odp. D, czyli checkbox #4
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            string answer = HintsClass.AnswerButtonChange(sender, CheckAnswer(correctAnsw: correctAnsw));
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = answer;
        }

        private bool CheckAnswer(int correctAnsw)
        {
            throw new NotImplementedException();
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
    }
}