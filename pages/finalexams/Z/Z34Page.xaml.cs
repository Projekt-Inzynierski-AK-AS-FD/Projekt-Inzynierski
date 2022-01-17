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
    /// Interaction logic for Z34Page.xaml
    /// </summary>
    public partial class Z34Page : Page
    {
        public Z34Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 4; //bo odp. D, czyli checkbox #4
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = @"\text{Odpowiedź:} \; \; P(A) = \frac{1}{9}";
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Wypisz wszystkie możliwe zdarzenia elementarne. }",
                @"\text{Wykonujemy niezależne rzuty dwoma kostkami. Na każdej kostce może wypaść wynik 1-6. Liczba zdarzeń elementarnych wynosi:}
\\ |\Omega | = 6 \cdot 6 = 36",
                @"\text{Zdarzenie A polega na wyrzuceniu w dwóch rzutach takiej liczby oczek, że ich iloczyn równy jest 12.}",
                @"\text{Istnieją 4 możliwe kombinacje zdarzeń sprzyjających:}
\\ (2,6), \; (3,4), \; (4, 3), \; (6,2) \\ \text{więc} \; \; |A|=4",
                @"\text{Oblicz prawdopodobieństwo korzystając ze wzoru:} \\
P(A) = \frac{|A|}{|\Omega |} \\
P(A)=\frac{4}{36} = \frac{1}{9}"
                 };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = "";
            this.hintFormula.Formula = hint;
        }
    }
}