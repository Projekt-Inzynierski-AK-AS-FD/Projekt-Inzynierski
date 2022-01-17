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
    /// Interaction logic for Z33Page.xaml
    /// </summary>
    public partial class Z33Page : Page
    {
        public Z33Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 4; //bo odp. D, czyli checkbox #4
        private void ShowAnsBtn(object sender, RoutedEventArgs e)
        {
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = @"P = \frac{16}{3}";
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Jedną z własności trapezów jest to, że przekątne trapezu dzielą go na trójkąty podobne ABS oraz CDS}",
@"\frac{AS}{SC} = \frac{3}{2} \; \text{więc skala podobieństwa tójkątów jest równa } \; k=\frac{3}{2} \; \text{więc boki tójkąta ABS są o tyle razy większe}",
@"\text{Oblicz pole powierzchni trójkąta CDS.} \\ 
\text{z własności trójkątów podobnych wynika, że trójkąt podobny w skali k będzia miał} \; k^2 \; \text{razy większe pole:}",
@"P_{ABS} = k^2 \cdot P_{CDS}",
@"12 = (\frac{3}{2} )^2 \cdot P_{CDS}",
@"12 = \frac{9}{4} \cdot P_{CDS}",
@"P_{CDS} = \frac{16}{3} = 5 \frac{1}{3}"
                 };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = "";
            this.hintFormula.Formula = hint;
        }
    }
}