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
        private const string BrakObslugi = "NIESTETY!!! Takie działanie jeszcze nie jest obsługiwane!";
        
        public Calculator()
        {
            InitializeComponent();
            ResultText.Text = "0";
            CurrentOperationText.Text = string.Empty;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = string.Empty;

            Button button = sender as Button;

            object currentNumber = button.Content;
            //ConsoleKeyInfo myString = Console.ReadKey();

            //if (myString.KeyChar == '1')
            //{
            //    currentNumber = "1";
            //    //switch (myString)
            //    //{
            //    //    case "0":
            //    //        Console.WriteLine("0");
            //    //        break;

            //    //    case "1":
            //    //        currentNumber = "1";
            //    //        break;

            //    //    case "2":
            //    //        Console.WriteLine("2");
            //    //        break;

            //    //    case "3":
            //    //        Console.WriteLine("3");
            //    //        break;

            //    //    case "4":
            //    //        Console.WriteLine("4");
            //    //        break;

            //    //    case "5":
            //    //        Console.WriteLine("5");
            //    //        break;

            //    //    case "6":
            //    //        Console.WriteLine("6");
            //    //        break;

            //    //    case "7":
            //    //        Console.WriteLine("7");
            //    //        break;

            //    //    case "8":
            //    //        Console.WriteLine("8");
            //    //        break;

            //    //    case "9":
            //    //        Console.WriteLine("9");
            //    //        break;
            //    //}
            //}
            //else
            //{
            //    currentNumber = button.Content;
            //}

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
            else if (CurrentOperationText.Text.EndsWith("∞")) { }
            else if (CurrentOperationText.Text == "0")
            {
                if (currentNumber.ToString() == ",")
                {
                    CurrentOperationText.Text += currentNumber;
                }
                else
                {
                    CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                    CurrentOperationText.Text += currentNumber;
                }
            }
            else if (CurrentOperationText.Text.EndsWith("√0"))
            {
                if (currentNumber.ToString() == ",")
                {
                    CurrentOperationText.Text += currentNumber;
                }
                else
                {
                    CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                    CurrentOperationText.Text += currentNumber;
                }
            }
            else if (CurrentOperationText.Text.EndsWith("+")
                     || CurrentOperationText.Text.EndsWith("-")
                     || CurrentOperationText.Text.EndsWith("*")
                     || CurrentOperationText.Text.EndsWith(":")
                     || CurrentOperationText.Text.EndsWith("√")
                     || CurrentOperationText.Text.EndsWith("/"))
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
                    string[] elements = CurrentOperationText.Text.Split('+');
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
                else if (Regex.Matches(CurrentOperationText.Text, "[-]").Count == 2)
                {
                    string[] elements = CurrentOperationText.Text.Split('-');
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
                else if (CurrentOperationText.Text.Contains("-") && CurrentOperationText.Text.Contains("+"))
                {
                    string[] elements = CurrentOperationText.Text.Split('-', '+');
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
                    string[] elements = CurrentOperationText.Text.Split('-');

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
                    string[] elements = CurrentOperationText.Text.Split(':');

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
                    string[] elements = CurrentOperationText.Text.Split('*');

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
                    string[] elements = CurrentOperationText.Text.Split('+');

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
                    string[] elements = CurrentOperationText.Text.Split(':');

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
                    string[] elements = CurrentOperationText.Text.Split('*');

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
                else if (CurrentOperationText.Text.Contains("-")) // zmieniona kolejność warunku z minusem, bo będąc przed pozostałymi znakami ma też pierszeństwo w wykonywaniu i nie można dopisać przecinka w drugiej liczbie xD
                {                                                 // TAK, bo tylko w przypadku minusa mogą siępojawić 2 znaki. Można go dać niżi. Ale jeszcze ten sam problem z minusem.
                    string[] elements = CurrentOperationText.Text.Split('-');

                    if (Regex.Matches(CurrentOperationText.Text, "[-]").Count == 2)
                    {
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
                            if (elements[2].Contains(","))
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
                    }
                    else
                    {
                        if (elements[1].Length >= 15) { }
                        else
                        {
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
            string operation = CurrentOperationText.Text;

            if (operation.ToString() == "-") { }
            else if (operation.EndsWith("/-")) { }
            else if (EndsWithOperation(operation))//zamienia z + na inne działanie
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += "+";
            }
            else if (CurrentOperationText.Text.EndsWith(",")) { }////////////////////////////////////////Nie doda znaku działania dopuki nie dopiszemy liczby po przecinku
            else if (CurrentOperationText.Text.EndsWith("√")) { }
            else if (CurrentOperationText.Text.Contains("²"))
            {
                CurrentOperationText.Text = "1/" + CalculateResult(operation).ToString();
            }
            else if (CurrentOperationText.Text.Contains(':') && CurrentOperationText.Text.EndsWith("0") || operation.Contains('/'))
            {
                SprawdzCzyNieZero(operation);
            }//////////////////////////////////////Nie dziel przez zero
            else if (ContainsOperation(operation) || CurrentOperationText.Text.Contains('-') && !EndsWithOperation(operation))
            {
                if (operation.StartsWith("-") && !ContainsOperation(operation))
                {
                    CurrentOperationText.Text += "+";
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text += "+";
                }
            }
            else if (ResultText.Text == ZeroNIE || ResultText.Text == BrakObslugi) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE) && !(ResultText.Text == BrakObslugi))
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
            string operation = CurrentOperationText.Text;

            if (operation.ToString() == "-") { }
            else if (operation.EndsWith("/-")) { }
            else if (EndsWithOperation(operation))
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += "-";
            }
            else if (CurrentOperationText.Text.EndsWith(",")) { }////////////////////////////////////////nie doda znaku działania dopuki nie dopiszemy liczby po przecinku
            else if (CurrentOperationText.Text.EndsWith("√")) { }
            else if (CurrentOperationText.Text.Contains("²"))
            {
                CurrentOperationText.Text = "1/" + CalculateResult(operation).ToString();
            }
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0") || operation.Contains('/'))
            {
                SprawdzCzyNieZero(operation);
            }
            else if (ContainsOperation(operation) || operation.Contains('-') && !EndsWithOperation(operation))
            {
                if (operation.StartsWith("-"))
                {
                    CurrentOperationText.Text += "-";
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text += "-";
                }
            }
            else if (ResultText.Text == ZeroNIE || ResultText.Text == BrakObslugi) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE) && !(ResultText.Text == BrakObslugi))
            {
                if (ResultText.Text.ToString() != "0")
                {
                    CurrentOperationText.Text = ResultText.Text + "-";
                }
                else
                {
                    CurrentOperationText.Text += "-";
                }
            }
            else
            {
                CurrentOperationText.Text += "-";
            }
        }
        private void Button_ClickMnozenie(object sender, RoutedEventArgs e)
        {
            string operation = CurrentOperationText.Text;//było var...

            if (operation.ToString() == "-") { }
            else if (operation.EndsWith("/-")) { }
            else if (EndsWithOperation(operation))
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += "*";
            }
            else if (CurrentOperationText.Text.EndsWith(",")) { }////////////////////////////////////////nie doda znaku działania dopuki nie dopiszemy liczby po przecinku
            else if (CurrentOperationText.Text.EndsWith("√")) { }
            else if (CurrentOperationText.Text.Contains("²"))
            {
                CurrentOperationText.Text = "1/" + CalculateResult(operation).ToString();
            }
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0") || operation.Contains('/'))
            {
                SprawdzCzyNieZero(operation);
            }
            else if (ContainsOperation(operation) || CurrentOperationText.Text.Contains('-') && !EndsWithOperation(operation))
            {
                if (operation.StartsWith("-") && !ContainsOperation(operation))
                {
                    CurrentOperationText.Text += "*";
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text += "*";
                }
            }
            else if (ResultText.Text == ZeroNIE || ResultText.Text == BrakObslugi) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE) && !(ResultText.Text == BrakObslugi))
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
            string operation = CurrentOperationText.Text;

            if (operation.ToString() == "-") { }
            else if (operation.EndsWith("/-")) { }
            else if (EndsWithOperation(operation))
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += ":";
            }
            else if (CurrentOperationText.Text.EndsWith(",")) { }////////////////////////////////////////nie doda znaku działania dopuki nie dopiszemy liczby po przecinku
            else if (CurrentOperationText.Text.EndsWith("√")) { }
            else if (CurrentOperationText.Text.Contains("²"))
            {
                CurrentOperationText.Text = "1/" + CalculateResult(operation).ToString();
            }
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0") || operation.Contains('/'))
            {
                SprawdzCzyNieZero(operation);
            }
            else if (ContainsOperation(operation) || CurrentOperationText.Text.Contains('-') && !EndsWithOperation(operation))
            {
                if (operation.StartsWith("-") && !ContainsOperation(operation))
                {
                    CurrentOperationText.Text += ":";
                }
                else
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
            }
            else if (ResultText.Text == ZeroNIE || ResultText.Text == BrakObslugi) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE) && !(ResultText.Text == BrakObslugi))
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
            string operation = CurrentOperationText.Text;

            if (CurrentOperationText.Text.EndsWith(",") || CurrentOperationText.Text.EndsWith("²") || operation.EndsWith("/-")) { }
            else if (CurrentOperationText.Text.Contains("/")) { }
            else if (CurrentOperationText.Text.Contains("√"))
            {
                //if (CurrentOperationText.Text.EndsWith("√"))
                //{
                //    //potęga n tego stopnia
                //}
                //else { }
            }
            else if (CurrentOperationText.Text.EndsWith("²")) { }
            else if (ResultText.Text == ZeroNIE || ResultText.Text == BrakObslugi) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE) && !(ResultText.Text == BrakObslugi))
            {
                if (ResultText.Text == "0")
                {
                    CurrentOperationText.Text = "√";
                }
                else
                {
                    CurrentOperationText.Text = "√" + ResultText.Text;
                }
            }
            else
            {
                CurrentOperationText.Text += "√";
            }
        }
        private void Button_ClickPotega(object sender, RoutedEventArgs e)
        {
            string operation = CurrentOperationText.Text;

            if (EndsWithOperation(operation)) { }//nie wstawia potęgi za działaniem
            else if (CurrentOperationText.Text.EndsWith(",") || CurrentOperationText.Text.EndsWith("√") || CurrentOperationText.Text.EndsWith("/")) { }
            else if (CurrentOperationText.Text.Contains(":") && CurrentOperationText.Text.EndsWith("0"))
            {
                SprawdzCzyNieZero(operation);
            }
            else if (CurrentOperationText.Text.Contains("²"))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            else if (CurrentOperationText.Text.Contains("/"))
            {
                string[] elements = CurrentOperationText.Text.Split('/', '²');

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
            else if (ResultText.Text == ZeroNIE || ResultText.Text == BrakObslugi) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE) && !(ResultText.Text == BrakObslugi))
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
            string operation = CurrentOperationText.Text;

            if (CurrentOperationText.Text.EndsWith(",") || CurrentOperationText.Text.EndsWith("√") || operation.EndsWith("/-")) { }
            else if (CurrentOperationText.Text.EndsWith(":")) 
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
                CurrentOperationText.Text = "1/" + CurrentOperationText.Text;
            }
            else if (CurrentOperationText.Text.Contains("²"))
            {
                CurrentOperationText.Text = "1/" + CalculateResult(operation).ToString();
            }
            else if (operation.Contains(':') || operation.Contains('/'))
            {
                SprawdzCzyNieZero(operation);
                CurrentOperationText.Text = "1/" + CalculateResult(operation).ToString();
            }
            else if (ContainsOperation(operation) || CurrentOperationText.Text.Contains('-'))
            {
                if (operation.StartsWith("-"))
                {
                    CurrentOperationText.Text = "1/" + CurrentOperationText.Text;
                }
                else
                {
                    CurrentOperationText.Text = CalculateResult(operation).ToString();
                    CurrentOperationText.Text = "1/" + CurrentOperationText.Text;
                }
            }
            else if (operation == "1/0" || operation == "1/0,")
            {
                ResultText.Text = ZeroNIE;
                CurrentOperationText.Text = string.Empty;
            }
            else if (CurrentOperationText.Text.Contains("/") && CurrentOperationText.Text.EndsWith("/"))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
                CurrentOperationText.Text = "1/" + CurrentOperationText.Text;
            }
            else if (CurrentOperationText.Text.EndsWith("/")) { }
            else if (string.IsNullOrEmpty(CurrentOperationText.Text) && !(ResultText.Text == ZeroNIE) && !(ResultText.Text == BrakObslugi) && !(ResultText.Text == "0"))
            {
                CurrentOperationText.Text = "1/" + ResultText.Text;
            }
            else
            {
                CurrentOperationText.Text = "1/" + CurrentOperationText.Text;
            }
        }
        private void Button_ClickWynik(object sender, RoutedEventArgs e)
        {
            string operation = CurrentOperationText.Text;

            if (Regex.Matches(operation, "[E]").Count >= 2 || Regex.Matches(ResultText.Text, "[E]").Count >= 2)
            {
                ResultText.Text = BrakObslugi;
                CurrentOperationText.Text = string.Empty;
            }
            else if (operation.ToString() == "-") { }
            else if (operation.EndsWith("/-")) { }
            else if (CurrentOperationText.Text.Contains("²"))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            else if (operation.Contains(':') && !operation.EndsWith(":") || operation.Contains('/'))
            {
                SprawdzCzyNieZero(operation);
            }
            else if (operation == "1/0" || operation == "1/0,")
            {
                ResultText.Text = ZeroNIE;
                CurrentOperationText.Text = string.Empty;
            }
            else if (operation.EndsWith("√"))
            {
                ResultText.Text = "0";
                CurrentOperationText.Text = string.Empty;
            }
            else
            {
                ResultText.Text = CalculateResult(operation).ToString();
                CurrentOperationText.Text = string.Empty;
            }
        }

        private void Button_Cofaj(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentOperationText.Text)) { }
            else
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
            }
        }
        private void Button_ClickCzysc(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "0";
            CurrentOperationText.Text = string.Empty;
        }
        private void Button_ClickCzyscWszystko(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "0";
            CurrentOperationText.Text = string.Empty;
        }

        private void Button_ClickHistory(object sender, RoutedEventArgs e) { }

        private bool ContainsOperation(string operation)
            => operation.Contains('+') || operation.Contains('*') || operation.Contains(':') || operation.Contains('²') || operation.Contains('√') || operation.Contains('/');//usunięto || operation.Contains('-')
        private bool EndsWithOperation(string operation)
            => CurrentOperationText.Text.EndsWith("+") || CurrentOperationText.Text.EndsWith("-") || CurrentOperationText.Text.EndsWith("*") || CurrentOperationText.Text.EndsWith(":");
        private void SprawdzCzyNieZero(string operation)
        {
            if (CurrentOperationText.Text.Contains(':'))
            {
                string[] elements = CurrentOperationText.Text.Split(':');

                if (elements[1].Contains(','))
                {
                    if (elements[1].Contains('√') || elements[1].Contains('²'))
                    {
                        if (CalculateResult(elements[1]) == 0)
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
                    else if (Convert.ToDouble(elements[1]) * 1 == 0)
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
                    if (elements[1].ToString() == "√")
                    {
                        ResultText.Text = ZeroNIE;
                        CurrentOperationText.Text = string.Empty;
                    }
                    else if (elements[1].Contains('√') || elements[1].Contains('²'))
                    {
                        if (CalculateResult(elements[1]) == 0)
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
                    else if (!(elements[1].Contains('√') || elements[1].Contains('²')) && Convert.ToDouble(elements[1]) * 1 == 0)
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
            }
            else if (CurrentOperationText.Text.Contains('/'))
            {
                string[] elements = CurrentOperationText.Text.Split('/');

                if (Convert.ToDouble(elements[1]) * 1 == 0)
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
        }

        private void RemoveUnlessPoint(string currentNumber)
        {
            if (currentNumber.ToString() == ",")
            {
                CurrentOperationText.Text += currentNumber;
            }
            else
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Remove(CurrentOperationText.Text.Length - 1);
                CurrentOperationText.Text += currentNumber;
            }
        }////////////////////////Temat do ogarnięcia. PS skrócenie funkcji warunkowej

        private double CalculateResult(string operation)
        {
            if (operation.Contains('E'))
            {
                if (operation.Contains("E+"))
                {
                    if (Regex.Matches(operation, "[+]").Count == 2)
                    {
                        if (operation.Contains('√'))
                        {
                            if (operation.Contains('²'))
                            {
                                string[] elements = operation.Split('+', '√', '²');
                                string firstNum = string.Join("+", elements.Take(2));

                                if (string.IsNullOrEmpty(elements[2]))
                                {
                                    return Convert.ToDouble(firstNum)
                                           + Math.Sqrt(Math.Pow(Convert.ToDouble(elements[3]), 2));
                                }
                                else
                                {
                                    return Convert.ToDouble(firstNum)
                                           + (Convert.ToDouble(elements[2])
                                              * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[3]), 2)));
                                }
                            }
                            else
                            {
                                string[] elements = operation.Split('+', '√');
                                string firstNum = string.Join("+", elements.Take(2));

                                if (string.IsNullOrEmpty(elements[2]))
                                {
                                    return Convert.ToDouble(firstNum)
                                           + Math.Sqrt(Convert.ToDouble(elements[3]));
                                }
                                else
                                {
                                    return Convert.ToDouble(firstNum)
                                           + (Convert.ToDouble(elements[2])
                                              * Math.Sqrt(Convert.ToDouble(elements[3])));
                                }
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('+', '²');
                            string firstNum = string.Join("+", elements.Take(2));

                            return Convert.ToDouble(firstNum)
                                    + Math.Pow(Convert.ToDouble(elements[2]), 2);
                        }
                        else
                        {
                            string[] elements = operation.Split(new[] { '+' }, 3);

                            if (string.IsNullOrEmpty(elements[2]))
                            {
                                elements[2] = elements[0] + elements[1];
                            }
                            string firstNum = string.Join("+", elements.Take(2));

                            return Convert.ToDouble(firstNum)
                                   + Convert.ToDouble(elements[2]);
                        }
                    }
                    else if (operation.Contains('-'))
                    {
                        if (operation.Contains('√'))
                        {
                            string[] elements = operation.Split('-', '√');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       - Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       - (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('-', '²');

                            return Convert.ToDouble(elements[0])
                                   - Math.Pow(Convert.ToDouble(elements[1]), 2);
                        }
                        else
                        {
                            string[] elements = operation.Split('-');
                            return Convert.ToDouble(elements[0])
                                   - Convert.ToDouble(elements[1]);
                        }
                    }
                    else if (operation.Contains('*'))
                    {
                        if (operation.Contains('√'))
                        {
                            string[] elements = operation.Split('*', '√');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('*', '²');
                            return Convert.ToDouble(elements[0])
                                   * Math.Pow(Convert.ToDouble(elements[1]), 2);
                        }
                        else
                        {
                            string[] elements = operation.Split('*');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                elements[1] = elements[0];
                            }

                            return Convert.ToDouble(elements[0]) * Convert.ToDouble(elements[1]);
                        }
                    }
                    else if (operation.Contains(':'))
                    {
                        if (operation.Contains('√'))
                        {
                            string[] elements = operation.Split(':', '√');

                            if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                            {
                                return Convert.ToDouble(elements[0])
                                       / Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       / (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split(':', '²');
                            return Convert.ToDouble(elements[0])
                                   / Math.Pow(Convert.ToDouble(elements[1]), 2);
                        }
                        else
                        {
                            string[] elements = operation.Split(':');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                elements[1] = elements[0];
                            }

                            return Convert.ToDouble(elements[0])
                                   / Convert.ToDouble(elements[1]);
                        }
                    }
                    else if (operation.Contains('/'))
                    {
                        string[] elements = operation.Split('/');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0])
                               / Convert.ToDouble(elements[1]);

                    }
                    else if (operation.Contains('√'))
                    {
                        if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('√', '²');
                            if (string.IsNullOrEmpty(elements[0]))
                            {
                                return Math.Sqrt(Math.Pow(Convert.ToDouble(elements[1]), 2));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[1]), 2));
                            }
                        }
                        else
                        {
                            string[] elements = operation.Split('√');

                            if (string.IsNullOrEmpty(elements[0]))
                            {
                                return Math.Sqrt(Convert.ToDouble(elements[1]));
                            }
                            
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Convert.ToDouble(elements[1]));
                            }
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('²');

                        return Math.Pow(Convert.ToDouble(elements[0]), 2);
                    }
                }

                else if (operation.Contains("E-"))
                {
                    if (Regex.Matches(operation, "[-]").Count == 2)
                    {
                        if (operation.Contains('√'))
                        {
                            if (operation.Contains('²'))
                            {
                                string[] elements = operation.Split('-', '√', '²');
                                string firstNum = string.Join("-", elements.Take(2));

                                if (string.IsNullOrEmpty(elements[2]))
                                {
                                    return Convert.ToDouble(firstNum)
                                           - Math.Sqrt(Math.Pow(Convert.ToDouble(elements[3]), 2));
                                }
                                else
                                {
                                    return Convert.ToDouble(firstNum)
                                           - (Convert.ToDouble(elements[2])
                                              * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[3]), 2)));
                                }
                            }
                            else
                            {
                                string[] elements = operation.Split('-', '√');
                                string firstNum = string.Join("-", elements.Take(2));

                                if (string.IsNullOrEmpty(elements[2]))
                                {
                                    return Convert.ToDouble(firstNum)
                                           - Math.Sqrt(Convert.ToDouble(elements[3]));
                                }
                                else
                                {
                                    return Convert.ToDouble(firstNum)
                                           - (Convert.ToDouble(elements[2])
                                              * Math.Sqrt(Convert.ToDouble(elements[3])));
                                }
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('-', '²');
                            string firstNum = string.Join("-", elements.Take(2));

                            return Convert.ToDouble(firstNum)
                                    - Math.Pow(Convert.ToDouble(elements[2]), 2);
                        }
                        else
                        {
                            string[] elements = operation.Split(new[] { '-' }, 3);

                            if (string.IsNullOrEmpty(elements[2]))
                            {
                                elements[2] = elements[0] + elements[1];
                            }

                            string firstNum = string.Join("-", elements.Take(2));

                            return Convert.ToDouble(firstNum) - Convert.ToDouble(elements[2]); //Convert.ToDouble(firstNum) + Convert.ToDouble(secondNum);
                        }
                    }
                    else if (operation.Contains('+'))//w wypadku notacji np. "1E-15 + coś tam"
                    {
                        if (operation.Contains('√'))
                        {
                            string[] elements = operation.Split('+', '√');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       + Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       + (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('+', '²');

                            return Convert.ToDouble(elements[0])
                                   + Math.Pow(Convert.ToDouble(elements[1]), 2);
                        }
                        else
                        {
                            string[] elements = operation.Split('+');
                            return Convert.ToDouble(elements[0])
                                   + Convert.ToDouble(elements[1]);
                        }
                    }
                    else if (operation.Contains('*'))
                    {
                        if (operation.Contains('√'))
                        {
                            string[] elements = operation.Split('*', '√');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('*', '²');
                            return Convert.ToDouble(elements[0])
                                   * Math.Pow(Convert.ToDouble(elements[1]), 2);
                        }
                        else
                        {
                            string[] elements = operation.Split('*');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                elements[1] = elements[0];
                            }

                            return Convert.ToDouble(elements[0]) * Convert.ToDouble(elements[1]);
                        }
                    }
                    else if (operation.Contains(':'))
                    {
                        if (operation.Contains('√'))
                        {
                            string[] elements = operation.Split(':', '√');

                            if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                            {
                                return Convert.ToDouble(elements[0])
                                       / Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       / (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split(':', '²');
                            return Convert.ToDouble(elements[0])
                                   / Math.Pow(Convert.ToDouble(elements[1]), 2);
                        }
                        else
                        {
                            string[] elements = operation.Split(':');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                elements[1] = elements[0];
                            }

                            return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);
                        }
                    }
                    else if (operation.Contains('/'))
                    {
                        string[] elements = operation.Split('/');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);

                    }
                    else if (operation.Contains('√'))
                    {
                        if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('√', '²');
                            if (string.IsNullOrEmpty(elements[0]))
                            {
                                return Math.Sqrt(Math.Pow(Convert.ToDouble(elements[1]), 2));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[1]), 2));
                            }
                        }
                        else
                        {
                            string[] elements = operation.Split('√');

                            if (string.IsNullOrEmpty(elements[0]))
                            {
                                return Math.Sqrt(Convert.ToDouble(elements[1]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Convert.ToDouble(elements[1]));
                            }
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('²');

                        return Math.Pow(Convert.ToDouble(elements[0]), 2);
                    }
                }
            }
            else if (operation.StartsWith("-"))
            {
                if (operation.Contains('+'))
                {
                    if (operation.Contains('√'))
                    {
                        if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('+', '√', '²');
                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       + Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       + (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2)));
                            }
                        }
                        else
                        {
                            string[] elements = operation.Split('+', '√');

                            if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                            {
                                return Convert.ToDouble(elements[0])
                                       + Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       + (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('+', '²');
                        return Convert.ToDouble(elements[0]) + Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        string[] elements = operation.Split('+');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) + Convert.ToDouble(elements[1]);
                    } // działa tak tlko gdy wymusimy postawienie plusa przy liczbie z minusem, blokuje to funkcja if(Contains operation) to oblicz bezzastanowienia xD
                }

                else if (Regex.Matches(operation, "[-]").Count == 2) /// dlaczego by niemogł być taki warunek w w warunku else w tej funkcji, a pojedyńczy minus na samym końcu i/więc dlaczego warunek z poj. - nie może być niżej
                {                                                    /// niż jest aktualnie (tam na dole)
                    string[] elements = operation.Split(new[] { '-' }, 3);

                    if (string.IsNullOrEmpty(elements[2]))
                    {
                        elements[2] = elements[0] + elements[1];
                    }

                    string firstNum = string.Join("-", elements.Take(2));

                    return Convert.ToDouble(firstNum) - Convert.ToDouble(elements[2]);
                }

                else if (operation.Contains('*'))
                {
                    if (operation.Contains('√'))
                    {
                        if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('*', '√', '²');
                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2)));
                            }
                        }
                        else
                        {
                            string[] elements = operation.Split('*', '√');

                            if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('*', '²');
                        return Convert.ToDouble(elements[0]) * Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        string[] elements = operation.Split('*');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) * Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains(':'))
                {
                    if (operation.Contains('√'))
                    {
                        if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split(':', '√', '²');
                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       / Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       / (Convert.ToDouble(elements[1])
                                          / Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2)));
                            }
                        }
                        else
                        {
                            string[] elements = operation.Split(':', '√');

                            if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                            {
                                return Convert.ToDouble(elements[0])
                                       / Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       / (Convert.ToDouble(elements[1])
                                          / Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split(':', '²');
                        return Convert.ToDouble(elements[0]) / Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        string[] elements = operation.Split(':');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains('/'))
                {
                    string[] elements = operation.Split('/');

                    if (string.IsNullOrEmpty(elements[1]))
                    {
                        elements[1] = elements[0];
                    }

                    return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);

                }

                else if (operation.Contains('√'))
                {
                    if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('√', '²');
                        if (string.IsNullOrEmpty(elements[0]))
                        {
                            return Math.Sqrt(Math.Pow(Convert.ToDouble(elements[1]), 2));
                        }
                        else
                        {
                            return Convert.ToDouble(elements[0])
                                   * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[1]), 2));
                        }
                    }
                    else
                    {
                        string[] elements = operation.Split('√');

                        if (string.IsNullOrEmpty(elements[0]))
                        {
                            return Math.Sqrt(Convert.ToDouble(elements[1]));
                        }
                        else if (string.IsNullOrEmpty(elements[1]))
                        {
                            return 0;
                        }
                        else
                        {
                            return Convert.ToDouble(elements[0])
                                   * Math.Sqrt(Convert.ToDouble(elements[1]));
                        }
                    }
                }

                else if (operation.Contains('²'))//może być potrzebny warunek że nie zawiera pozostałych (niepewny)!!!
                {
                    string[] elements = operation.Split('²');

                    return Math.Pow(Convert.ToDouble(elements[0]), 2);
                }
            }
            else
            {
                if (operation.Contains('+'))
                {
                    if (operation.Contains('√'))
                    {
                        if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('+', '√', '²');
                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       + Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       + (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2)));
                            }
                        }
                        else
                        {
                            string[] elements = operation.Split('+', '√');

                            if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                            {
                                return Convert.ToDouble(elements[0])
                                       + Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       + (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('+', '²');
                        return Convert.ToDouble(elements[0]) + Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        string[] elements = operation.Split('+');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) + Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains('-'))
                {
                    if (operation.StartsWith("-"))
                    {
                        string[] elements = operation.Split('-');

                        elements[0] = "0";

                        return Convert.ToDouble(elements[0])
                                   - Convert.ToDouble(elements[1]);
                    }
                    else
                    {
                        if (operation.Contains('√'))
                        {
                            if (operation.Contains('²'))
                            {
                                string[] elements = operation.Split('-', '√', '²');
                                if (string.IsNullOrEmpty(elements[1]))
                                {
                                    return Convert.ToDouble(elements[0])
                                           - Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2));
                                }
                                else
                                {
                                    return Convert.ToDouble(elements[0])
                                           - (Convert.ToDouble(elements[1])
                                              * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2)));
                                }
                            }
                            else
                            {
                                string[] elements = operation.Split('-', '√');

                                if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                                {
                                    return Convert.ToDouble(elements[0])
                                           - Math.Sqrt(Convert.ToDouble(elements[2]));
                                }
                                else
                                {
                                    return Convert.ToDouble(elements[0])
                                           - (Convert.ToDouble(elements[1])
                                              * Math.Sqrt(Convert.ToDouble(elements[2])));
                                }
                            }
                        }
                        else if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('-', '²');
                            return Convert.ToDouble(elements[0])
                                   - Math.Pow(Convert.ToDouble(elements[1]), 2);
                        }
                        else if (operation.Contains("/-") && !operation.StartsWith("-"))
                        {
                            string[] elements = operation.Split('/', '-');

                            if (string.IsNullOrEmpty(elements[2]))
                            {
                                return Convert.ToDouble(elements[0]) / 0;
                            }

                            return (Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[2])) * -1;
                        }
                        else
                        {
                            string[] elements = operation.Split('-');

                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                elements[1] = elements[0];
                            }

                            return Convert.ToDouble(elements[0])
                                   - Convert.ToDouble(elements[1]);
                        }
                    }
                }

                else if (operation.Contains('*'))
                {
                    if (operation.Contains('√'))
                    {
                        if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split('*', '√', '²');
                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2)));
                            }
                        }
                        else
                        {
                            string[] elements = operation.Split('*', '√');

                            if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                            {
                                return Convert.ToDouble(elements[0])
                                       * Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       * (Convert.ToDouble(elements[1])
                                          * Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('*', '²');
                        return Convert.ToDouble(elements[0]) * Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        string[] elements = operation.Split('*');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) * Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains(':'))
                {
                    if (operation.Contains('√'))
                    {
                        if (operation.Contains('²'))
                        {
                            string[] elements = operation.Split(':', '√', '²');
                            if (string.IsNullOrEmpty(elements[1]))
                            {
                                return Convert.ToDouble(elements[0])
                                       / Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       / (Convert.ToDouble(elements[1])
                                          / Math.Sqrt(Math.Pow(Convert.ToDouble(elements[2]), 2)));
                            }
                        }
                        else
                        {
                            string[] elements = operation.Split(':', '√');

                            if (string.IsNullOrEmpty(elements[1]))                          //Jeśli nic nie ma przed znakiem działania (.Split(...))
                            {
                                return Convert.ToDouble(elements[0])
                                       / Math.Sqrt(Convert.ToDouble(elements[2]));
                            }
                            else
                            {
                                return Convert.ToDouble(elements[0])
                                       / (Convert.ToDouble(elements[1])
                                          / Math.Sqrt(Convert.ToDouble(elements[2])));
                            }
                        }
                    }
                    else if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split(':', '²');
                        return Convert.ToDouble(elements[0]) / Math.Pow(Convert.ToDouble(elements[1]), 2);
                    }
                    else
                    {
                        string[] elements = operation.Split(':');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                        return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains('/'))
                {
                    if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('/', '²');

                        return Convert.ToDouble(elements[0]) / (Math.Pow(Convert.ToDouble(elements[1]), 2));
                    }
                    else
                    {
                        string[] elements = operation.Split('/');

                        if (string.IsNullOrEmpty(elements[1]))
                        {
                            elements[1] = elements[0];
                        }

                    return Convert.ToDouble(elements[0]) / Convert.ToDouble(elements[1]);
                    }
                }

                else if (operation.Contains('√'))
                {
                    if (operation.Contains('²'))
                    {
                        string[] elements = operation.Split('√', '²');
                        if (string.IsNullOrEmpty(elements[0]))
                        {
                            return Math.Sqrt(Math.Pow(Convert.ToDouble(elements[1]), 2));
                        }
                        else
                        {
                            return Convert.ToDouble(elements[0])
                                   * Math.Sqrt(Math.Pow(Convert.ToDouble(elements[1]), 2));
                        }
                    }
                    else
                    {
                        string[] elements = operation.Split('√');

                        if (string.IsNullOrEmpty(elements[0]))
                        {
                            return Math.Sqrt(Convert.ToDouble(elements[1]));
                        }
                        else if (string.IsNullOrEmpty(elements[1]))
                        {
                            return 0;
                        }
                        else
                        {
                            return Convert.ToDouble(elements[0])
                                   * Math.Sqrt(Convert.ToDouble(elements[1]));
                        }
                    }
                }

                else if (operation.Contains('²'))//może być potrzebny warunek że nie zawiera pozostałych (niepewny)!!!
                {
                    string[] elements = operation.Split('²');

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
