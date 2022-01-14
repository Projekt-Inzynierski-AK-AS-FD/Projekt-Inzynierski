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
            this.DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 4; //bo odp. D, czyli checkbox #4
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = "Przepraszamy, sprawdzanie zadań otwartych nie jest jeszcze dostępne.";
        }
        private void HintBtn(object sender, RoutedEventArgs e)
        {
            clickCounter += 1;
            //tutaj wstawić treść podpowiedzi i cyk do funkcji
            // @"\text{} \; x=-2, \text{}"
            string[] hintsArray = { @"\text{Funkcja niedostępna, przepraszamy!}",
                 };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = "";
            this.hintFormula.Formula = hint;
        }
    }
}