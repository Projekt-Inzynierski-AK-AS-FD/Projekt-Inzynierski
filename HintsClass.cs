using System;
using System.Collections.Generic;
using System.Diagnostics;
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
namespace Abituria
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class HintsClass
    {
        public static string AnswerButtonChange(object sender, bool ansChecked)
        {
            Button button = sender as Button;
            string message;
            if (ansChecked)
            {
                button.Background = Brushes.LimeGreen;
                message = "To prawidłowa odpowiedź!";
            }
            else
            {
                button.Background = Brushes.IndianRed;
                message = "Odpowiedź jest niepoprawna. Spróbuj jeszcze raz.";
            }
            return message;
        }
        public static string Hint(int counter, string[] hintsArray)
        {
            string hint = hintsArray[0];
            for (int i = 1; i < counter; i++)
            {
                if (i < hintsArray.Length)
                {
                    hint = hint + @" \\ " + hintsArray[i];
                }
            }
            return hint;
        }
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
