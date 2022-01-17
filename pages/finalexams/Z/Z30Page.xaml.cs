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
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = @"\text{Odpowiedź:} \; x=-\frac{1}{2} \; \bigvee \; x=8 ";
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"\frac{}{}
            string[] hintsArray = { @"\text{Upewnij się, że nie wystąpi dzielenie przez 0 (mianownik), zapisując założenie:}
\\ x-7 \neq 0 \\ x \neq 7",
                @"\text{Przemnóż obie strony równiania przez wyrażenie} \; x-7
\\ \frac{x+8}{x-7} = 2x \; \; / \cdot (x-7)
\\ x+8=2x^2 - 14 x
\\ -2x^2 + 15x+8 = 0",
                @"\text{Korzystając z metody delty rozwiąż równanie kwadratowe:}
\\ \Delta = b^2 -4ac = 15^2 - 4 /cdot (-2) /cdot 8=225-(-64)=225+64=289 \\ \sqrt{\Delta} = \sqrt{289} = 17",
                @"x_1 = \frac{-b - \sqrt{\Delta}}{2a} = \frac{-15-17}{2 \cdot (-2)} = \frac{-32}{-4} = 8 \\
x_2 = \frac{-b + \sqrt{\Delta}}{2a} = \frac{-15+17}{2 \cdot (-2)} = \frac{2}{-4} = -\frac{1}{2}",
                @"\text{Założenia nie wykluczają żadnego z rozwiązań, więc oba są poprawne:} \\
x=-\frac{1}{2} \; \; \bigvee \; \; x=8"
                 };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = "";
            this.hintFormula.Formula = hint;
        }
    }
}