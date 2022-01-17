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
    /// Interaction logic for Z35Page.xaml
    /// </summary>
    public partial class Z35Page : Page
    {
        public Z35Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = @"\text{Odpowiedź:} \; x=0, \; q =-2 ";
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"\frac{}{}
            string[] hintsArray = { @"\text{Oblicz wartość } \; \; a_4 \; \; \text{oraz} \; \; a_11.",
                @"\text{Ciąg} \; a_n \; \text{określony jest wzorem} \; \frac{5-3n}{7}
\\ \text{Czwarty i jedenasty wyraz tego ciągu znajdują się też w innym, trójwyrazowym ciągu geometrycznym, w którym należy szukać wartości niewiadomej} \; x.",
                @"\text{Aby obliczyć wartość} \; a_4 \; \text{do wzoru ciągu należy podstawić} \; n=4:
\\ a_4 = \frac{5-3 \cdot 4}{7} = \frac{5-12}{7} = \frac{-7}{7} = -1",
                @"\text{Aby obliczyć wartość} \; a_11 \; \text{do wzoru ciągu należy podstawić} \; n=11:
\\ a_11 = \frac{5-3 \cdot 11}{7} = \frac{5-33}{7} = \frac{-28}{7} = -4",
                @"\text{Z własności ciągów geometrycznych wynika, że dla trzech kolejnych wyrazów ciągu geometrycznego zachodzi równość:}
\\ a_2^2 = a_1 \cdot a_3",
                @"\text{Aby obliczyć wartość} \; x \; \text{znajdującą się w środkowym wyrazie ciągu geometrycznego, podstaw znane wartości:}
\\ (x^2 +2)^2 = (-1) \cdot (-4) \\ x^4 + 4x^2 +4 = 4 \\ x^4 + 4x^2 = 0",
                @"\text{Powstałe równanie jest czwartego stopnia, więc w celu jego rozwiązania wyłącz wartość } \; x^2:
\\ x^2(x^2 + 4) = 0",
                @"\text{Tak jak w przypadku postępowania z postacią iloczynową, przyrównaj wartości do zera:} 
\\ x^2 = 0 \; \; \bigvee \; \; x^2+4=0 \\ x=0 \; \; \bigvee \; \; x^2 = -4",
                @"\text{Nie istnieje taka liczba rzeczywista, która podniesiona do kwadratu da wartość -4, dlatego rozwiązanie to} \; x=0.",
                @"\text{Drugi wyraz ciągu geometrycznego to } \; x^2+2. \; \text{Oblicz jego wartość:}
\\ a_2=0^2+2 \\ a_2 = 0 + 2 \\ a_2 = 2",
                @"\text{Ciąg geometryczny przyjmuje postać:} \; \; -1, 2, -4",
                @"\text{Oblicz wartość ilorazu} \; q=\frac{a_2}{a_1}:
\\ q=\frac{2}{-1} \\ q=-2"
                 };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = "";
            this.hintFormula.Formula = hint;
        }
    }
}