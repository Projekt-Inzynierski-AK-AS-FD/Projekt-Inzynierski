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
using System.Windows.Shapes;

namespace Abituria
{
    /// <summary>
    /// Interaction logic for CalcQuadraticFunc.xaml
    /// </summary>
    public partial class CalcQuadraticFunc : Window
    {
        public CalcQuadraticFunc()
        {
            InitializeComponent();
        }

        private void ShowResult(object sender, RoutedEventArgs e)
        {
            // POBIERANIE INPUTU
            // bezpieczniejsze niż double.Parse, lepiej weryfikuje i nie wyrzuca wyjątku w przypadku nieprawidłowej wartości
            // z double.Parse trzeba by napisać wyjątek i wychodzi podobnie, bo i tak potrzeba weryfikacji, ale TryParse działa pewniej i jest zalecany
            string valA = fieldA.Text;
            string valB = fieldB.Text;
            string valC = fieldC.Text;
            double a, b, c = 0;
            double.TryParse(valA, out a);
            double.TryParse(valB, out b);
            double.TryParse(valC, out c);

            //weryfikacja poprawności wprowadzonych danych
            if (a == 0)
            {
                MessageBox.Show("Psss, w każdej funkcji kwadratowej współczynnik a jest liczbą rzeczywistą różną od 0! Spróbuj jeszcze raz.", "Nieprawidłowa wartość!");
                Reset();
                return;
            }
            if (double.TryParse(valA, out a) != true || double.TryParse(valB, out b) != true || double.TryParse(valC, out c) != true)
            {
                MessageBox.Show("Ups, coś poszło nie tak. Sprawdź, czy wprowadzone dane są prawidłowe i spróbuj jeszcze raz.", "Nieprawidłowa wartość!");
                Reset();
                return;
            }

            FunQuad(a, b, c);
            this.groupResult.Visibility = Visibility.Visible;
        }
        private void ResetBtn(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            fieldA.Text = "";
            fieldB.Text = "";
            fieldC.Text = "";
            this.groupResult.Visibility = Visibility.Collapsed;
        }

        /*
        private void ButtonOgolna(object sender, RoutedEventArgs e)
        {
            if (this.pOgolna.Visibility == Visibility.Collapsed && this.buttonPrzelicz.Visibility == Visibility.Collapsed && this.buttonReset.Visibility == Visibility.Collapsed)
            {
                this.pOgolna.Visibility = Visibility.Visible;
                this.buttonPrzelicz.Visibility = Visibility.Visible;
                this.buttonReset.Visibility = Visibility.Visible;
            }
            else
            {
                this.pOgolna.Visibility = Visibility.Collapsed;
                this.buttonPrzelicz.Visibility = Visibility.Collapsed;
                this.buttonReset.Visibility = Visibility.Collapsed;
                this.resultHead.Visibility = Visibility.Collapsed;
                this.result.Visibility = Visibility.Collapsed;
            }
        }
        */

        private void FunQuad(double a, double b, double c)
        {
            string[] subscript= new string[] { "₀", "₁", "₂" };
            // obliczenia
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double x0 = (-b) / (2 * a);
            double x1 = Math.Round(((-b) - Math.Sqrt(delta)) / (2 * a), 2);
            double x2 = Math.Round(((-b) + Math.Sqrt(delta)) / (2 * a), 2);

            // wyświetlanie pierwiastków
            if (delta < 0)
            {
                string resultTxt = "Δ < 0, funkcja nie posiada miejsc zerowych";
                result.Text = resultTxt;
            }
            else if (delta == 0)
            {
                string resultTxt = $"Δ = 0, funkcja posiada jedno miejsce zerowe, gdzie wierzchołek dotyka osi x: \n x" +  subscript[0] + $" = {0}";
                result.Text = resultTxt;
            }
            else
            {
                string resultTxt = $"Δ > 0, funkcja posiada dwa miejsca zerowe: \n x" + subscript[1] + $" = {x1}                                     x" + subscript[2] + $" = {x2}";
                result.Text = resultTxt;
            }

            // obliczenia dla postaci kanonicznej
            double p = Math.Round(x0, 2);
            double q = Math.Round((-delta) / (4 * a), 2);
            string wierzch = $"({p} ; {q})";

            this.result.Visibility = Visibility.Visible;
            PosOgolnaShow(a, b, c);
            PosKanonShow(a, p, q);
            PosIloczynShow(a, x1, x2, delta);
            Explanation(a, b, c, delta, wierzch, x1, x2);

        }

        private void PosOgolnaShow(double a, double b, double c)
        {
            string ogolna = "";
            string kwadrat = "²";

            if (a == 1)
            {
                ogolna = "x" + kwadrat;
            }
            else if (a == -1)
            {
                ogolna = "-x" + kwadrat;
            }
            else
            {
                ogolna = $"{a}x" + kwadrat;
            }

            if (b > 0)
            {
                if (b == 1)
                {
                    ogolna = ogolna + " + x";
                }
                else
                {
                    ogolna = ogolna + " + " + $"{b}x";
                }
            }
            else if (b < 0)
            {
                if (b == -1)
                {
                    ogolna = ogolna + " - x";
                }
                else
                {
                    ogolna = ogolna + " - " + $"{(b * -1)}x";
                }
            }

            if (c > 0)
            {
                ogolna = ogolna + " + " + $"{c}";
            }
            else if (c < 0)
            {
                ogolna = ogolna + " - " + $"{(c * -1)}";
            }

            pOgolna.Text = ogolna;
        }
        private void PosKanonShow(double a, double p, double q)
        {
            // f(x)=a(x−p)2+q 
            string kwadrat = "²";
            string kanoniczna = $"f(x) = {a}(x";

            if (p > 0 || p == 0)
            {
                kanoniczna = kanoniczna + $" - {p})" + kwadrat;
            }
            else
            {
                kanoniczna = kanoniczna + $" + {p * (-1)})" + kwadrat;
            }

            if (q > 0 || q == 0)
            {
                kanoniczna = kanoniczna + $" + {q}";
            }
            else
            {
                kanoniczna = kanoniczna + $" - {q * (-1)}";
            }

            pKanoniczna.Text = kanoniczna;
        }
        private void PosIloczynShow(double a, double x1, double x2, double delta)
        {
            string kwadrat = "²";
            string iloczynowa = "";

            if (delta < 0)
            {
                iloczynowa = "Funkcja nie ma miejsc zerowych, nie ma też zatem postaci iloczynowej!";
            }
            else if(delta == 0)
            {
                if(x1 < 0)
                {
                    iloczynowa = $"f(x) = {a}(x + {x1})" + kwadrat;
                }
                else
                {
                    iloczynowa = $"f(x) = {a}(x - {x1})" + kwadrat;
                }
            }
            else
            {
                iloczynowa = iloczynowa + "(x ";
                if (x1 > 0 || x1 == 0)
                {
                    iloczynowa = iloczynowa + $"- {x1})(x ";
                }
                else
                {
                    iloczynowa = iloczynowa + $"+ {x1 * (-1)})(x ";
                }
                if (x2 > 0 || x2 == 0)
                {
                    iloczynowa = iloczynowa + $"- {x2})";
                }
                else
                {
                    iloczynowa = iloczynowa + $"+ {x2 * (-1)})";
                }
            }
            pIloczynowa.Text = iloczynowa;
        }
        private void Explanation(double a, double b, double c, double delta, string wierzch, double x1, double x2)
        {
            string[] specialScript = new string[] { "₀", "₁", "₂", "²" };
            string explained = "Znając wzór na postać ogólną funkcji kwadratowej, zaczynamy od policzenia Δ. \nUżyjemy wzoru Δ = b" + specialScript[3] + " − 4⋅a⋅c" + "\n";
            explained = explained + "Δ = " + $"({b}) - 4⋅({a})⋅({c}) = {delta}";
            explanation.Text = explained;
            string wierzcholek = $"Współrzędne wierzchołka paraboli znajdują się w punkcie W(p, q), czyli W = {wierzch}";
        }
    }
}

