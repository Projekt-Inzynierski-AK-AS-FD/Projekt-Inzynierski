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
            //zastąpić to casem po postawieniu też iloczynej i kanocznicznej, mlem
            //i oczywiście trzeba dodać weryfikację
            
            double a = double.Parse(fieldA.Text);
            double b = double.Parse(fieldB.Text);
            double c = double.Parse(fieldC.Text);

            //weryfikacja
            if(a == 0)
            {
                MessageBox.Show("Pamiętaj, że w każdej funkcji kwadratowej współczynnik a jest liczbą rzeczywistą różną od 0!");
                return;
            }


            FunQuad(a, b, c);


        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            fieldA.Text = "";
            fieldB.Text = "";
            fieldC.Text = "";
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
            // obliczenia
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double x0 = (-b) / (2 * a);
            double x1 = Math.Round(((-b) - Math.Sqrt(delta)) / (2 * a), 2);
            double x2 = Math.Round(((-b) + Math.Sqrt(delta)) / (2 * a), 2);

            // wyświetlanie wyniku
            if (delta < 0)
            {
                string resultTxt = "Δ < 0, funkcja nie posiada miejsc zerowych";
                result.Text = resultTxt;
            }
            else if (delta == 0)
            {
                string resultTxt = "Δ = 0, funkcja posiada jedno miejsce zerowe, gdzie wierzchołek dotyka osi x";
                result.Text = resultTxt;
            }
            else
            {
                string resultTxt = $"Δ > 0, funkcja posiada dwa miejsca zerowe: x1 = {x1} i x2 = {x2}";
                result.Text = resultTxt;
            }


            this.result.Visibility = Visibility.Visible;
            PosOgolnaShow(a, b, c);


        }
        private void PosOgolnaShow(double a, double b, double c)
        {
            // wyświetlanie postaci ogólnej f. kwadratowej
            // do poprawy przy b = -1 !
            if (b > 0)
            {
                if (c > 0)
                {
                    if (a == 1)
                    {
                        if (b == 1)
                        {
                            this.pOgolna.Text = $"y = x2 + x + {c}";
                        }
                        else
                        {
                            this.pOgolna.Text = $"y = x2 + {b}x + {c}";
                        }
                    }
                    else if (b == 1)
                    {
                        this.pOgolna.Text = $"y = {a}x2 + x + {c}";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2 + {b}x + {c}";
                    }
                }
                else if (c < 0)
                {
                    if (a == 1)
                    {
                        if (b == 1)
                        {
                            this.pOgolna.Text = $"y = x2 + x - {c * (-1)}";
                        }
                        else
                        {
                            this.pOgolna.Text = $"y = x2 + {b}x - {c * (-1)}";
                        }
                    }
                    else if (b == 1)
                    {
                        this.pOgolna.Text = $"y = {a}x2 + x - {c * (-1)}";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2 + {b}x - {c * (-1)}";
                    }      
                }
                else if (c == 0)
                {
                    if (a == 1)
                    {
                        if (b == 1)
                        {
                            this.pOgolna.Text = $"y = x2 + x";
                        }
                        else
                        {
                            this.pOgolna.Text = $"y = x2 + {b}x";
                        }
                    }
                    else if (b == 1)
                    {
                        this.pOgolna.Text = $"y = {a}x2 + x";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2 + {b}x";
                    }     
                }
            }
            else if (b < 0)
            {
                if (c > 0)
                {
                    if(a == 1)
                    {
                        this.pOgolna.Text = $"y = x2 - {b * (-1)}x + {c}";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2 - {b * (-1)}x + {c}";
                    } 
                }
                else if (c < 0)
                {
                    if (a == 1)
                    {
                        this.pOgolna.Text = $"y = x2 - {b * (-1)}x - {c * (-1)}";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2 - {b * (-1)}x - {c * (-1)}";
                    }
                }
                else if (c == 0)
                {
                    if (a == 1)
                    {
                        this.pOgolna.Text = $"y = x2 - {b * (-1)}x";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2 - {b * (-1)}x";
                    } 
                }
            }
            else if (b == 0)
            {
                if (c > 0)
                {
                    if (a == 1)
                    {
                        this.pOgolna.Text = $"y = x2 + {c}";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2 + {c}";
                    }    
                }
                else if (c < 0)
                {
                    if (a == 1)
                    {
                        this.pOgolna.Text = $"y = x2 - {c * (-1)}";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2 - {c * (-1)}";
                    }  
                }
                else if (c == 0)
                {
                    if (a == 1)
                    {
                        this.pOgolna.Text = $"y = x2";
                    }
                    else
                    {
                        this.pOgolna.Text = $"y = {a}x2";
                    } 
                }
            }
        }
    }
}

