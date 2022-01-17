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
    /// Interaction logic for Z31Page.xaml
    /// </summary>
    public partial class Z31Page : Page
    {
        public Z31Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 4; //bo odp. D, czyli checkbox #4
        private void ShowAnsBtn(object sender, RoutedEventArgs e)
        {
            this.brdHint.Visibility = Visibility.Visible;
            this.hintAnswer.Text = "Dowiedź na podstawie wzorów skróconego mnożenia.";
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Spróbuj wymnożyć} \; b \; \text{przez wartości w nawiasach i uporządkować całe wyrażenie, co daje:} \\
5b^2 - 4ab+a^2 \geq 0 \\ a^2 - 4ab+5b^2 \geq 0",
                @"\text{Otrzymany zapis przypomina nieco to, co przedstawiają wzory skróconego mnożenia, ale przeszkodą jest wartość} \\
5b^2. \; \text{Należy rozpisać tę liczbę jako} \\
4b^2+b^2 \; \text{co da:} \\ a^2 - 4ab + 4b^2 + b^2 \geq 0",
                @"\text{Skorzystaj ze wzoru skróconego mnożenia:} \\
(a-b)^2 = a^2 - 2ab + b^2 \; \text{czyli:} \\ (a-2b^)2+b^2 \geq 0",
                @"(a-2b)^2 \; \text{jest większa od zera lub równa zero,ponieważ jakakolwiek liczba podniesiona do kwadratu da wynik nieujemny. \\ 
Podobnie wartość} \; b^2 \; /text{jest większa lub równa zero. To oznacza, że suma tych dwóch nieujemnych liczb na pewno będzie większa lub równa zero, co kończy dowodzenie.}"
                 };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintAnswer.Text = "";
            this.hintFormula.Formula = hint;
        }
    }
}