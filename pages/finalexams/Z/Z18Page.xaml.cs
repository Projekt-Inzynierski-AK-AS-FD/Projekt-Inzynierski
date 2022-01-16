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
    /// Interaction logic for Z18Page.xaml
    /// </summary>
    public partial class Z18Page : Page
    {
        public Z18Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
        int clickCounter = 0;
        readonly int correctAnsw = 1; //bo odp. D, czyli checkbox #4
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
            string[] hintsArray = { @"\text{Przeanalizuj sytuację i oblicz miary kątów} \; OBC \; \text{i} \; OCB.",
                @"\text{Trójkąt} \; COB \; \text{jest równoramienny, wobec czegokąty przy podstawie} \; BC \; \text{mają jednakową miarę.}",
                @"\text{Miara jednego z kątów } \; COB \; \text{jest znana i wynosi } \; 100^\circ . \\
\text{Suma miar kątów w trójkącie wynosi } \; 180^ \circ , \; \text{co oznacza, że na kąty } \\
OBC \; \text{i} \; OCB  \; \text{pozostało łącznie } \; 80^\circ .",
                @"80^\circ : 2=40^\circ , \; \text{więc każdy z tych kątów ma miarę } \; 40^\circ .",
                @"\text{W kolejnym kroku należy obliczyć miary kąta BAC. } \\ \text{Odcinki} \; OB \; \text{oraz} \; OC \;
\text{są dwusiecznymi kątów } ABC \; \text{i} \; ACB \\
\text{oraz muszą mieć po } \; 80^\circ , \; \text{skoro kąty } \; OBC \; \text{oraz} \; OCB \; \text{mają po } \; 40^\circ .",
                @"|BAC|=180^ \circ -80^ \circ -80^ \circ =20^ \circ"
            };
            string hint = HintsClass.Hint(clickCounter, hintsArray);
            this.brdHint.Visibility = Visibility.Visible;
            this.hintField.Text = "";
            this.hintFormula.Formula = hint;
        }
        private bool CheckAnswer(int correctAnsw)
        {
            bool isAnsCorrect;
            if (checkBox1.IsChecked == true)
            {
                if (checkBox4.IsChecked == true || checkBox2.IsChecked == true || checkBox3.IsChecked == true)
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