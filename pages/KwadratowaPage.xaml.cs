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
using WpfMath;
namespace Abituria.pages
{
    public partial class KwadratowaPage : Page
    {
        public KwadratowaPage()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
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
            if (!double.TryParse(valA, out a) || !double.TryParse(valB, out b) || !double.TryParse(valC, out c))
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
        private void FunQuad(double a, double b, double c)
        {
            string[] subscript = new string[] { "₀", "₁", "₂" };
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
                string resultTxt = $"Δ = 0, funkcja posiada jedno miejsce zerowe, gdzie wierzchołek dotyka osi x: \n 𝑥" + subscript[0] + $" = {0}";
                result.Text = resultTxt;
            }
            else
            {
                string resultTxt = $"\nΔ > 0, funkcja posiada dwa miejsca zerowe: \n 𝑥" + subscript[1] + $" = {x1}                                     𝑥" + subscript[2] + $" = {x2}";
                result.Text = resultTxt;
            }
            // obliczenia dla postaci kanonicznej
            double p = Math.Round(x0, 2);
            double q = Math.Round((-delta) / (4 * a), 2);
            string wierzch = $"({p} ; {q})";
            this.result.Visibility = Visibility.Visible;
            PosOgolnaShow(a, b, c);
            PosKanonShow(a, p, q);
            PosIloczynShow(a, x1, x2, delta, wierzch);
            Explanation(a, b, c, delta, wierzch, x1, x2, x0, p, q);

        }

        private void PosOgolnaShow(double a, double b, double c)
        {
            string ogolna = "";
            string kwadrat = "²";

            if (a == 1)
            {
                ogolna = "𝑓(𝑥) = 𝑥" + kwadrat;
            }
            else if (a == -1)
            {
                ogolna = "𝑓(𝑥) = -𝑥" + kwadrat;
            }
            else
            {
                ogolna = $"𝑓(𝑥) = {a}𝑥" + kwadrat;
            }

            if (b > 0)
            {
                if (b == 1)
                {
                    ogolna = ogolna + " + 𝑥";
                }
                else
                {
                    ogolna = ogolna + " + " + $"{b}𝑥";
                }
            }
            else if (b < 0)
            {
                if (b == -1)
                {
                    ogolna = ogolna + " - 𝑥";
                }
                else
                {
                    ogolna = ogolna + " - " + $"{(b * -1)}𝑥";
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
            string kanoniczna = $"𝑓(𝑥) = {a}(𝑥";

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
        private void PosIloczynShow(double a, double x1, double x2, double delta, string wierzch)
        {
            string kwadrat = "²";
            string iloczynowa = "";
            string parable = "";

            if (delta < 0)
            {
                iloczynowa = "Funkcja nie ma miejsc zerowych, nie ma też zatem postaci iloczynowej!";
            }
            else if (delta == 0)
            {
                if (x1 < 0)
                {
                    iloczynowa = $"𝑓(𝑥) = {a}(𝑥 + {x1})" + kwadrat;
                }
                else
                {
                    iloczynowa = $"𝑓(𝑥) = {a}(𝑥 - {x1})" + kwadrat;
                }
            }
            else
            {
                iloczynowa = iloczynowa + $"𝑓(𝑥) = {a}(x ";
                if (x1 > 0 || x1 == 0)
                {
                    iloczynowa = iloczynowa + $"- {x1})(𝑥 ";
                }
                else
                {
                    iloczynowa = iloczynowa + $"+ {x1 * (-1)})(𝑥 ";
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

            if (a > 0)
            {
                parable = "Ramiona paraboli skierowane są do góry, ponieważ współczynnik 𝒂 jest dodatni: ⎝⎠";
            }
            else if (a < 0)
            {
                parable = "Ramiona paraboli skierowane są do dołu, ponieważ współczynnik 𝒂 jest ujemny: ⎛⎞";
            }

            string wierzcholek = $"Współrzędne wierzchołka paraboli znajdują się w punkcie 𝑊 = (𝑝;𝑞), czyli 𝑊 = {wierzch}\n";
            pParable.Text = parable + "\n" + wierzcholek;


        }
        private void Explanation(double a, double b, double c, double delta, string wierzch, double x1, double x2, double x0, double p, double q)
        {
            string[] specialScript = new string[] { "₀", "₁", "₂", "²", "√" };
            string delText = "";
            _ = Math.Round(Math.Sqrt(delta), 2);
            if (delta < 0)
            {
                delText = "Δ < 0 i funkcja nie posiada miejsc zerowych";

            }
            else if (delta == 0)
            {
                delText = $"Δ = 0, funkcja posiada jedno miejsce zerowe: 𝑥" + specialScript[0] + $" = {x0}";
            }
            else
            {
                delText = $"Δ > 0, funkcja posiada zatem dwa miejsca zerowe: 𝑥" + specialScript[1] + $" = {x1} oraz 𝑥" + specialScript[2] + $" = {x2}";
            }

            string explained1 = "Znając wzór na postać ogólną funkcji kwadratowej, zaczynamy od wyliczenia wartości Δ (delty, inaczej wyróżnika funkcji kwadratowej). Użyjemy wzoru:\n";
            explanation1.Text = explained1;
            string explained2 = $"Δ = 𝑏{specialScript[3]} − 4⋅𝑎⋅𝑐";
            explanation2.Text = explained2;
            string explained3 = $"Δ = ({b}){specialScript[3]} - 4⋅({a})⋅({c}) = {delta}";
            explanation3.Text = explained3;
            string explained4 = $@"
Sama znajomość delty da nam już bardzo dużo, bo dowiemy się ile pierwiastków trójmianu kwadratowego (to znaczy miejsc zerowych funkcji kwadratowej) znajdziemy w naszej konkretnej funkcji.

    Pod uwagę bierzemy zawsze jeden z trzech przypadków:
◍ Δ > 0 oznaczać będzie, że funkcja ma dwa rozwiązania - miejsca zerowe 𝑥{specialScript[1]} oraz 𝑥{specialScript[2]},
◍ Δ = 0 funkcja ma jedno rozwiązanie, gdzie 𝑥{specialScript[0]} jest jedynym miejscem zerowym,
◍ Δ < 0 funkcja nie posiada miejsc zerowych.

W tym przypadku, {delText}. 

Znając współczynniki funkcji kwadratowej, możemy przekształcić jej postać ogólną do postaci kanonicznej lub iloczynowej. Postać kanoniczna funkcji kwadratowej wyrażona jest wzorem:
";
            explanation4.Text = explained4;
            string explained5 = $"𝑓(𝑥) = 𝑎(𝑥 − 𝑝){specialScript[3]} + 𝑞";
            explanation5.Text = explained5;
            string explained6 = $"\nDo uzupełnienia wzoru brakuje nam współrzędnych wierzchołka paraboli, 𝑝 i 𝑞. Możesz zauważyć, iż współczynnik 𝑝 można obliczyć używając takiego samego wzoru, jak w przypadku x{specialScript[0]}. Dla 𝑝 i 𝑞 istnieją następujące wzory:";
            explanation6.Text = explained6;
            string explained8 = $@"Wierzchołek 𝑊 = {wierzch}, wobec czego po podstawieniu:
                              𝑓(𝑥) = ({a})(𝑥 − ({p})){specialScript[3]} + ({q})

Dla dobra przekształcenia naszej funkcji w postać iloczynową ponownie sięgniemy po znalezione wcześniej miejsca zerowe. 
Postać iloczynowa funkcji kwadratowej wyrażona jest wzorem:
";
            explanation8.Text = explained8;
            string explained9 = $"𝑓(𝑥) = 𝑎(𝑥 − 𝑥{specialScript[1]})(𝑥 − 𝑥{specialScript[2]})";
            explanation9.Text = explained9;
            _ = $"𝑓(𝑥) = ({a})(𝑥 − ({x1}))(𝑥 − ({x2}))\n";
            string explained10;
            if (delta < 0)
            {
                explained10 = "\nFunkcja nie ma miejsc zerowych, nie istnieje zatem jej postać iloczynowa!";
            }
            else if (delta == 0)
            {
                explained10 = $"\nΔ = 0, wystarczy więc policzyć x{specialScript[0]} i skrócić zapis: \n𝑓(𝑥) = ({a})(𝑥 − ({x1})){specialScript[3]}\n";
            }
            else
            {
                explained10 = $"𝑓(𝑥) = ({a})(𝑥 − ({x1}))(𝑥 − ({x2}))\n";
            }
            explanation10.Text = explained10;
        }
    }
}
