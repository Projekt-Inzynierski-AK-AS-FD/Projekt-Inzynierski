using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Abituria
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public partial class Calculator : Window
    {
        private const string ZeroNIE = "Nie można dzielić przez ZERO!!!";
        
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
            else if (CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":"))
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
            else if (CurrentOperationText.Text.EndsWith("²")) { }
            else if (CurrentOperationText.Text.Contains('E'))
            {
                if (Regex.Matches(CurrentOperationText.Text, "[+]").Count == 2)
                {
                    var elements = CurrentOperationText.Text.Split('+');
                    if (elements[2].Length >= 15) { }
                    else
                    {
                        if (elements[2].Contains(","))
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
                }
                else if (CurrentOperationText.Text.Contains("-"))
                {
                    var elements = CurrentOperationText.Text.Split('-');

                    if (elements[1].Length >= 15) { }
                    else
                    {
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
                }
                else if (CurrentOperationText.Text.Contains(":"))
                {
                    var elements = CurrentOperationText.Text.Split(':');

                    if (elements[1].Length >= 15) { }
                    else
                    {
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
                }
                else if (CurrentOperationText.Text.Contains("*"))
                {
                    var elements = CurrentOperationText.Text.Split('*');

                    if (elements[1].Length >= 15) { }
                    else
                    {
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
                }
                else
                {
                    if (CurrentOperationText.Text.Length >= 15) { }
                    else
                    {
                        if (CurrentOperationText.Text.Contains(","))
                        {
                            if (currentNumber.ToString() == ",") { } //jeśli istnieje już przecinek nie wypisuje kolejnego.
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
            }
            else if (!CurrentOperationText.Text.Contains('E'))
            {
                if (CurrentOperationText.Text.Contains("+"))
                {
                    var elements = CurrentOperationText.Text.Split('+');

                    if (elements[1].Length >= 15) { }
                    else
                    {
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
                }
                else if (CurrentOperationText.Text.Contains("-"))
                {
                    var elements = CurrentOperationText.Text.Split('-');

                    if (elements[1].Length >= 15) { }
                    else
                    {
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
                }
                else if (CurrentOperationText.Text.Contains(":"))
                {
                    var elements = CurrentOperationText.Text.Split(':');

                    if (elements[1].Length >= 15) { }
                    else
                    {
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
                }
                else if (CurrentOperationText.Text.Contains("*"))
                {
                    var elements = CurrentOperationText.Text.Split('*');

                    if (elements[1].Length >= 15) { }
                    else
                    {
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
                }
                else
                {
                    if (CurrentOperationText.Text.Length >= 15) { }
                    else
                    {
                        if (CurrentOperationText.Text.Contains(","))
                        {
                            if (currentNumber.ToString() == ",") { } //jeśli istnieje już przecinek nie wypisuje kolejnego.
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
            }
            
        }
        private void Button_ClickDodawanie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":"))//zamienia z + na inne działanie
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += "+";
            }
            else if (CurrentOperationText.Text.EndsWith(",")) { }////////////////////////////////////////Nie doda znaku działania dopuki nie dopiszemy liczby po przecinku
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0"))
            {
                var elements = CurrentOperationText.Text.Split(':');
                if (Convert.ToDouble(elements[1]) * 1 == 0)
                {
                    ResultText.Text = ZeroNIE;
                    CurrentOperationText.Text = string.Empty;
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text += "+";
                }
            }//////////////////////////////////////Nie dziel przez zero
            else if (ContainsOperation(operation) && !(CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":")))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
                CurrentOperationText.Text += "+";
            }//Zawiera ale się nie kończy
            else if (ResultText.Text == ZeroNIE) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE))
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

            if (CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":"))
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += "-";
            }
            else if (CurrentOperationText.Text.EndsWith(",")) { }////////////////////////////////////////nie doda znaku działania dopuki nie dopiszemy liczby po przecinku
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0"))
            {
                var elements = CurrentOperationText.Text.Split(':');
                if (Convert.ToDouble(elements[1]) * 1 == 0)
                {
                    ResultText.Text = ZeroNIE;
                    CurrentOperationText.Text = string.Empty;
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text += "-";
                }
            }
            else if (ContainsOperation(operation) && !(CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":")))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
                CurrentOperationText.Text += "-";
            }
            else if (ResultText.Text == ZeroNIE) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE))
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
            string operation = CurrentOperationText.Text;//było var...

            if (CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":"))
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += "*";
            }
            else if (CurrentOperationText.Text.EndsWith(",")) { }////////////////////////////////////////nie doda znaku działania dopuki nie dopiszemy liczby po przecinku
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0"))
            {
                var elements = CurrentOperationText.Text.Split(':');
                if (Convert.ToDouble(elements[1]) * 1 == 0)
                {
                    ResultText.Text = ZeroNIE;
                    CurrentOperationText.Text = string.Empty;
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text += "*";
                }
            }
            else if (ContainsOperation(operation) && !(CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":")))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
                CurrentOperationText.Text += "*";
            }
            else if (ResultText.Text == ZeroNIE) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE))
            {
                CurrentOperationText.Text = ResultText.Text + "*";
            }
            else
            {
                CurrentOperationText.Text += "*";
            }
        }
        private void Button_ClickDzielenie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":"))
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += ":";
            }
            else if (CurrentOperationText.Text.EndsWith(",")) { }////////////////////////////////////////nie doda znaku działania dopuki nie dopiszemy liczby po przecinku
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0"))
            {
                var elements = CurrentOperationText.Text.Split(':');
                if (Convert.ToDouble(elements[1]) * 1 == 0)
                {
                    ResultText.Text = ZeroNIE;
                    CurrentOperationText.Text = string.Empty;
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text += ":";
                }
            }
            else if (ContainsOperation(operation) && !(CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":")))
            {
                if (CurrentOperationText.Text.EndsWith(":0"))
                {
                    ResultText.Text = ZeroNIE;
                    CurrentOperationText.Text = string.Empty;
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text += ":";
                }
            }
            else if (ResultText.Text == ZeroNIE) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE))
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

            if (CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":")) { }//nie wstawia potęgi za działaniem
            else if (CurrentOperationText.Text.EndsWith(",")) { }
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0"))
            {
                var elements = CurrentOperationText.Text.Split(':');
                if (Convert.ToDouble(elements[1]) * 1 == 0)
                {
                    ResultText.Text = ZeroNIE;
                    CurrentOperationText.Text = string.Empty;
                }
                else
                {
                    CurrentOperationText.Text += "²";
                }
            }
            else if (CurrentOperationText.Text.Contains("²"))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            else if (ResultText.Text == ZeroNIE) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE))
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
                var elements = CurrentOperationText.Text.Split(':');

                if (elements[1] == "0")
                {
                    ResultText.Text = ZeroNIE;
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
            => operation.Contains('+') || operation.Contains('-') || operation.Contains('*') || operation.Contains(':') || operation.Contains('²');

        private double CalculateResult(string operation)
        {
            if (operation.Contains('E'))
            {
                if (Regex.Matches(operation, "[+]").Count == 2)
                {
                    var elements = operation.Split('+');

                    //if (String.IsNullOrEmpty(elements[1]))
                    //{
                    //    elements[2] = operation.Concat(elements[0] + elements[1]);
                    //}

                    return Convert.ToDouble(elements[0] + elements[1]) + Convert.ToDouble(elements[2]);
                }
                else if (operation.Contains('-'))
                {
                    var elements = operation.Split('-');

                    if (String.IsNullOrEmpty(elements[1]))
                    {
                        elements[1] = elements[0];
                    }

                    return Convert.ToDouble(elements[0]) - Convert.ToDouble(elements[1]);
                }

                else if (operation.Contains('*'))
                {
                    var elements = operation.Split('*');

                    if (String.IsNullOrEmpty(elements[1]))
                    {
                        elements[1] = elements[0];
                    }

                    return Convert.ToDouble(elements[0]) * Convert.ToDouble(elements[1]);
                }

                else if (operation.Contains(':'))
                {
                    var elements = operation.Split(':');

                    if (String.IsNullOrEmpty(elements[1]))
                    {
                        elements[1] = elements[0];
                    }

                    return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);
                }

                else if (operation.Contains('/'))
                {
                    var elements = operation.Split('/');

                    if (String.IsNullOrEmpty(elements[1]))
                    {
                        elements[1] = elements[0];
                    }

                    return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);

                }

                else if (operation.Contains('√'))
                {
                    var elements = operation.Split('√');


                    if (String.IsNullOrEmpty(elements[0]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                    {
                        return Math.Sqrt(Convert.ToDouble(elements[1]));
                    }
                    else
                    {
                        return Convert.ToDouble(elements[0]) * Math.Sqrt(Convert.ToDouble(elements[1]));
                    }
                }

                else if (operation.Contains('²'))
                {
                    var elements = operation.Split('²');

                    return Math.Pow(Convert.ToDouble(elements[0]), 2);
                }
            }
            else
            {
                if (operation.Contains('+'))
                {
                    if (operation.Contains('√'))
                    {
                        var elements = operation.Split('√', '+');


                        if (String.IsNullOrEmpty(elements[0]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                        {
                            return Math.Sqrt(Convert.ToDouble(elements[1])) + Convert.ToDouble(elements[2]);
                        }
                        else
                        {
                            return Convert.ToDouble(elements[0]) * Math.Sqrt(Convert.ToDouble(elements[1])) + Convert.ToDouble(elements[2]);
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        var elements = operation.Split('+', '²');
                        return Convert.ToDouble(elements[0]) / Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        var elements = operation.Split('+');

                        if (String.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) + Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains('-'))
                {
                    if (operation.Contains('²'))
                    {
                        var elements = operation.Split('-', '²');
                        return Convert.ToDouble(elements[0]) - Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        var elements = operation.Split('-');

                        if (String.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) - Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains('*'))
                {
                    if (operation.Contains('²'))
                    {
                        var elements = operation.Split('*', '²');
                        return Convert.ToDouble(elements[0]) * Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        var elements = operation.Split('*');

                        if (String.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) * Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains(':'))
                {
                    if (operation.Contains('²'))
                    {
                        var elements = operation.Split(':', '²');
                        return Convert.ToDouble(elements[0]) / Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        var elements = operation.Split(':');

                        if (String.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains('/'))
                {
                    var elements = operation.Split('/');

                    if (String.IsNullOrEmpty(elements[1]))
                    {
                        elements[1] = elements[0];
                    }

                    return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);

                }

                else if (operation.Contains('√'))
                {
                    var elements = operation.Split('√');


                    if (String.IsNullOrEmpty(elements[0]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                    {
                        return Math.Sqrt(Convert.ToDouble(elements[1]));
                    }
                    else
                    {
                        return Convert.ToDouble(elements[0]) * Math.Sqrt(Convert.ToDouble(elements[1]));
                    }
                }

                else if (operation.Contains('²'))//może być potrzebny warunek że nie zawiera pozostałych (niepewny)!!!
                {
                    var elements = operation.Split('²');
                    
                    return Math.Pow(Convert.ToDouble(elements[0]), 2);
                }
            }

            return default;
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
