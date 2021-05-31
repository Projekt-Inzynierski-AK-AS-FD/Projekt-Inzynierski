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

namespace Abituria_szkielet
{
    /// <summary>
    /// Logika interakcji dla klasy Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
            ResultText.Text = string.Empty;
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

            CurrentOperationText.Text += "+";
        }

        private void Button_ClickOdejmowanie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "-";
        }

        private void Button_ClickMnozenie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "*";
        }

        private void Button_ClickDzielenie(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += ":";
        }

        private void Button_ClickWynik(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            ResultText.Text = CalculateResult(operation).ToString();

            CurrentOperationText.Text = string.Empty;
        }

        private bool ContainsOperation(string operation)
            => operation.Contains('+') || operation.Contains('-') || operation.Contains('*') || operation.Contains(':');

        private long CalculateResult(string operation)
        {
            if (operation.Contains('+'))
            {
                var elements = operation.Split('+');

                return long.Parse(elements[0]) + long.Parse(elements[1]);
            }

            if (operation.Contains('-'))
            {
                var elements = operation.Split('-');

                return long.Parse(elements[0]) - long.Parse(elements[1]);
            }

            if (operation.Contains('*'))
            {
                var elements = operation.Split('*');

                return long.Parse(elements[0]) * long.Parse(elements[1]);
            }

            if (operation.Contains(':'))
            {
                var elements = operation.Split(':');

                return long.Parse(elements[0]) / long.Parse(elements[1]);
            }

            return default;
        }
    }
}
