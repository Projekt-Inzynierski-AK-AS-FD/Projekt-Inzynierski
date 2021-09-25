using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Abituria
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
            ResultText.Text = "0";
            CurrentOperationText.Text = string.Empty;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = string.Empty;

            var button = sender as Button;

            var currentNumber = button.Content;

            if (string.IsNullOrEmpty(CurrentOperationText.Text))// i jeśli zawiera "znak,znak" w całym ciągu znaków to nie wypisuj... i to w rozszerzonym kalkulatorze, NIE tu!!!
            {
                if (currentNumber.ToString() == ",")
                {
                    CurrentOperationText.Text = "0" + currentNumber;
                }
                else
                {
                    CurrentOperationText.Text += currentNumber;
                }
            }
            else if (CurrentOperationText.Text.EndsWith("+")|| CurrentOperationText.Text.EndsWith("-")|| CurrentOperationText.Text.EndsWith("*")|| CurrentOperationText.Text.EndsWith(":"))
            {
                if (currentNumber.ToString() == ",")
                {
                    CurrentOperationText.Text += "0" + currentNumber;
                }
                else
                {
                    CurrentOperationText.Text += currentNumber;
                }
            }
            else if (CurrentOperationText.Text.Contains("+"))
            {
                var elements = CurrentOperationText.Text.Split('+');

                if (elements[1].Contains(","))
                {
                    if (currentNumber.ToString() == ",") { }     //jeśli istnieje już przecinek nie wypisuje kolejnego.
                    else
                    {
                        CurrentOperationText.Text += currentNumber;
                    }
                }  
                else
                {
                    CurrentOperationText.Text += currentNumber;
                }
            }
            else if (CurrentOperationText.Text.Contains("-"))
            {
                var elements = CurrentOperationText.Text.Split('-');

                if (elements[1].Contains(","))
                {
                    if (currentNumber.ToString() == ",") { }
                    else
                    {
                        CurrentOperationText.Text += currentNumber;
                    }
                }
                else
                {
                    CurrentOperationText.Text += currentNumber;
                }
            }
            else if (CurrentOperationText.Text.Contains(":"))
            {
                var elements = CurrentOperationText.Text.Split(':');

                if (elements[1].Contains(","))
                {
                    if (currentNumber.ToString() == ",") { }
                    else
                    {
                        CurrentOperationText.Text += currentNumber;
                    }
                }
                else
                {
                    CurrentOperationText.Text += currentNumber;
                }
            }
            else if (CurrentOperationText.Text.Contains("*"))
            {
                var elements = CurrentOperationText.Text.Split('*');

                if (elements[1].Contains(","))
                {
                    if (currentNumber.ToString() == ",") { }
                    else
                    {
                        CurrentOperationText.Text += currentNumber;
                    }
                }
                else
                {
                    CurrentOperationText.Text += currentNumber;
                }
            }
            else
            {
                if (CurrentOperationText.Text.Contains(","))
                {
                    if (currentNumber.ToString() == ",")
                    {
                        //jeśli istnieje już przecinek nie wypisuje kolejnego.
                    }
                    else
                    {
                        CurrentOperationText.Text += currentNumber;
                    }
                }
                else
                {
                    CurrentOperationText.Text += currentNumber;
                }
            }
            
        }
        private void Button_ClickDodawanie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            if(string.IsNullOrEmpty(CurrentOperationText.Text))
            {
                CurrentOperationText.Text = ResultText.Text + "+";
            }
            else
            {
                CurrentOperationText.Text += "+";
            }
            
        }
        private void Button_ClickOdejmowanie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            if (string.IsNullOrEmpty(CurrentOperationText.Text))
            {
                CurrentOperationText.Text = ResultText.Text + "-";
            }
            else
            {
                CurrentOperationText.Text += "-";
            }
        }
        private void Button_ClickMnozenie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            if (string.IsNullOrEmpty(CurrentOperationText.Text))
            {
                CurrentOperationText.Text = ResultText.Text + "*";
            }
            else
            {
                CurrentOperationText.Text += "*";
            }
        }
        //private void Button_ClickDzielenie(object sender, RoutedEventArgs e)
        //{
        //    var operation = CurrentOperationText.Text;

        //    if (ContainsOperation(operation))
        //    {
        //        CurrentOperationText.Text = CalculateResult(operation).ToString();
        //    }

        //    if (string.IsNullOrEmpty(CurrentOperationText.Text))
        //    {
        //        CurrentOperationText.Text = ResultText.Text + ":";
        //    }
        //    else
        //    {
        //        CurrentOperationText.Text += ":";
        //    }
        //}

        private void Button_ClickDzielenie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            
            if (ContainsOperation(operation))
            {

                if (Dziel_Zero(operation) == true)
                {
                    ResultText.Text = "Nie można dzielić przez ZERO!!!";
                    CurrentOperationText.Text = string.Empty;
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                }
            }

            if (string.IsNullOrEmpty(CurrentOperationText.Text) && ResultText.Text == "Nie można dzielić przez ZERO!!!")
            {
                CurrentOperationText.Text = string.Empty;
            }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text))
            {
                CurrentOperationText.Text = ResultText.Text + ":";
            }
            else
            {
                CurrentOperationText.Text += ":";
            }
        }
        private void Button_ClickPierwiastek(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "√";
        }
        private void Button_ClickPotega(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            if (string.IsNullOrEmpty(CurrentOperationText.Text))
            {
                CurrentOperationText.Text = ResultText.Text + "²";
            }
            else
            {
                CurrentOperationText.Text += "²";
            }
        }
        private void Button_ClickUlamek(object sender, RoutedEventArgs e)
        {
            CurrentOperationText.Text = "1/" + CurrentOperationText.Text;
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
        }
        private void Button_ClickWynik(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (operation.Contains(':'))
            {
                if (Dziel_Zero(operation) == true)
                {
                    ResultText.Text = "Nie można dzielić przez ZERO!!!";
                    CurrentOperationText.Text = string.Empty;
                }
                else
                {
                    ResultText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text = string.Empty;
                }
            }
            else
            {
                ResultText.Text = CalculateResult(operation).ToString();
                CurrentOperationText.Text = string.Empty;
            }
        }

        private bool ContainsOperation(string operation)
            => operation.Contains('+') || operation.Contains('-') || operation.Contains('*') || operation.Contains(':');

        private double OperationAfterOperation(string operation)
        {
            if (operation.Contains('+'))
            {
                var elements = operation.Split('+');

                return double.Parse(elements[0]) + double.Parse(elements[1]);
            }

            return default;
        }

        private double CalculateResult(string operation)
        {
            if (operation.Contains('+'))
            {
                var elements = operation.Split('+');

                if (String.IsNullOrEmpty(elements[1]))
                {
                    elements[1] = elements[0];
                }

                return double.Parse(elements[0]) + double.Parse(elements[1]);
            }

            if (operation.Contains('-'))
            {
                var elements = operation.Split('-');

                if (String.IsNullOrEmpty(elements[1]))
                {
                    elements[1] = elements[0];
                }

                return double.Parse(elements[0]) - double.Parse(elements[1]);
            }

            if (operation.Contains('*'))
            {
                var elements = operation.Split('*');

                if (String.IsNullOrEmpty(elements[1]))
                {
                    elements[1] = elements[0];
                }

                return double.Parse(elements[0]) * double.Parse(elements[1]);
            }

            if (operation.Contains(':'))
            {
                var elements = operation.Split(':');

                if (String.IsNullOrEmpty(elements[1]))
                {
                    elements[1] = elements[0];
                }

                //if (elements[1] == "0")
                //{
                //    return 0;
                //}
                //else
                //{
                return double.Parse(elements[0]) / double.Parse(elements[1]);
                //}
            }

            if (operation.Contains('/'))
            {
                var elements = operation.Split('/');

                if (String.IsNullOrEmpty(elements[1]))
                {
                    elements[1] = elements[0];
                }

                return double.Parse(elements[0]) / double.Parse(elements[1]);
            }

            if (operation.Contains('√'))
            {
                var elements = operation.Split('√');


                if (String.IsNullOrEmpty(elements[0]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                {
                    return Math.Sqrt(double.Parse(elements[1]));
                }
                else
                {
                    return double.Parse(elements[0]) * Math.Sqrt(double.Parse(elements[1]));
                }
            }

            if (operation.Contains('²'))
            {
                var elements = operation.Split('²');

                return Math.Pow(double.Parse(elements[0]),2);
            }

            if (operation.Contains('²'))
            {
                var elements = operation.Split('²');

                return Math.Pow(double.Parse(elements[0]), 2);
            }

            return default;
        }
        private bool Dziel_Zero(string operation)
        {
            operation = CurrentOperationText.Text;
            var elements = operation.Split(':');

            if (elements[1] == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Funkcja: po naciśnięciu na textbox ResultText prawym przyciskiem myszy jego zawartość zostaje skopiowana do schowka, używa eventu MouseLeftButtonUp
        private void ResultText_Kopiuj(object sender, RoutedEventArgs e)
        {
            //używa metody obiektu schowka
            Clipboard.SetText(ResultText.Text);

            //to pozwoli na późniejsze wklejenie ZE schowka DO pola tekstowego, np. z kalku do zadania, ale trzeba określić konkretne miejsce wklejenia
            //ResultText.Text = Clipboard.GetText();
        }
        }
}
