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

            var currentNumber = button.Name[button.Name.Length - 1];

            CurrentOperationText.Text += currentNumber;
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
        private void Button_ClickDzielenie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            if (string.IsNullOrEmpty(CurrentOperationText.Text))
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

            CurrentOperationText.Text += "²";
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

            ResultText.Text = CalculateResult(operation).ToString();

            CurrentOperationText.Text = string.Empty;
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

                if (elements[1] == "0")
                {
                    return 0;
                }
                else
                {
                    return double.Parse(elements[0]) / double.Parse(elements[1]);
                }
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

    }
}