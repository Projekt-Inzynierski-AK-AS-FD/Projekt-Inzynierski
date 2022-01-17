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
    /// Interaction logic for Z32Page.xaml
    /// </summary>
    public partial class Z32Page : Page
    {
        public Z32Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 4; //bo odp. D, czyli checkbox #4
        private void ShowAnsBtn(object sender, RoutedEventArgs e)
        {
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = @"|BD| = 12";
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Sporządź rysunek. Trójkąt DBC jest równoramienny, a |CD| = |BD|. Skorzystaj z własności trójkątów o kątach} \\ \; 30^ \cdot, \; 60^ \cdot \; 90^ \cdot \; \text{by obliczyć długość odcinka CD.}",
@"\text{Trójkąt ADC ma kąty }",
@"\text{} \; 30^ \cdot, \; 60^ \cdot \; 90^ \cdot \; \text{Według własności trójkątów, przyprostokątna leżąca przy kącie } \; 60^ \cdot \\
\text{jest dwa razy krótsza od przeciwprostokątnej, a zatem:} \\
|CD| = 2 \cdot 6 \\ |CD| = 12",
@"\text{Boki CD oraz BD mają jednakową miarę, więc} \\ |BD| = 12"
                 };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Formula = "";
            this.hintFormula.Formula = hint;
        }
    }
}