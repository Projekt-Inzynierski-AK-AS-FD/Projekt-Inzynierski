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
    /// Interaction logic for Z29Page.xaml
    /// </summary>
    public partial class Z29Page : Page
    {
        public Z29Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = @"\text{Odpowiedź:} \; \; x \in (- \infty ; -1> \cup <5;+ \infty ) ";
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Doprowadź nierówność do postaci ogólnej przenosząc wyrazy na lewa stronę.}",
                @"x^2 - 5 \geq 4x \\ x^2 - 4x - 5 \geq 0",
                @"\\ \text{Znajdź miejsca zerowe:} \\
\Delta = b^2 -4ac = (-4)^2 - 4 /cdot 1 /cdot (-5)=16-(-20)=16+20=36 \\ \sqrt{\Delta} = \sqrt{36} = 6",
                @"x_1 = \frac{-b - \sqrt{\Delta}}{2a} = \frac{-(-4)-6}{2 \cdot 1} = \frac{4-6}{2} = \frac{-2}{2} = -1 \\
x_2 = \frac{-b + \sqrt{\Delta}}{2a} = \frac{-(-4)+6}{2 \cdot 1} = \frac{4+6}{2} = \frac{10}{2} = 5",
                @"\text{Narysuj wykres paraboli pamiętając, że współczynnik kierunkowy a jest dodatni, a więc ramiona paraboli} \\
\text{będą skierowane ku górze. Zaznacz na osi i zamaluj (bo wystąpił znak} \; \geq \; \text{) miejsca zerowe:}
\\ x = -1, \; x=5",
                @"\text{Odczytaj rozwiązanie z wykresu zwracając uwagę na to, co znalazła się na i nad osią. Rozwiązaniem nierówności jest przedział:}  
\\ x \in (- \infty ; -1> \cup <5;+ \infty ) "
                 };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = "";
            this.hintFormula.Formula = hint;
        }
    }
}